#This script generates the coupled/chapter classes and huffman coding values.
#Does NOT generate the block classes, those are artisnally hand-written.

$urls = @(
	"https://raw.githubusercontent.com/xiph/vorbis/master/lib/books/coupled/res_books_stereo.h",
	"https://raw.githubusercontent.com/xiph/vorbis/master/lib/books/uncoupled/res_books_uncoupled.h"
)

#Breaks the books code into names/quant_list/LengthList/params
$book_block_regex = "_vq_quantlist__(.*?)\[\] = ({[^}]*});.*?_vq_lengthlist__\1\[\] = ({[^}]*});.*?static_codebook _\1 = {([^}]*)}"
#Does the same for huffmancoding
$huffman_regex = "_huff_lengthlist__(.*?)\[\] = ({[^}]*});.*?static_codebook _huff_book__\1 = {([^}]*)};"

#parse name format into frequency/managed/coupled/page
$chap_page_reg = "(\d+)([cu])(n?\d+)_(s?m?)_?p(\d+)_(\d+)";
#do simmilar for huffman encodings
$huffman_name_regex = "(\d+)([cu])(n?\d+)_(s?m?)_?(single|short|long)"

$opts_reg = "\s*(\d+),\s+\d+,\s*\(char \*\).*?,\s*(-?\d+),\s+(-?\d+),\s+(-?\d+),\s+(-?\d+),\s+(-?\d+)";

#Template to fill out with details
$page_template = @"
namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo{0}.{1}.{2}
{{
    public class {3} : IStaticCodeBook
    {{
        public int Dimensions {{ get; }} = {4};

        public byte[] LengthList {{ get; }} = {5};

        public CodeBookMapType MapType {{ get; }} = (CodeBookMapType){6};
        public int QuantMin {{ get; }} = {7};
        public int QuantDelta {{ get; }} = {8};
        public int Quant {{ get; }} = {9};
        public int QuantSequenceP {{ get; }} = {10};

        public int[] QuantList {{ get; }} = {11};
    }}
}}
"@

$output_dir = "./BookBlocks"

function Generate-Books()
{
	param (
		[string]$PageContent
	)

	$book_matches = [Regex]::Matches($PageContent, $book_block_regex, [System.Text.RegularExpressions.RegexOptions]::Singleline)
	foreach($match in $book_matches)
	{
		$name = $match.Groups[1].Value
		$quant_list = $match.Groups[2].Value;
		$length_list = $match.Groups[3].Value;
		$book_params = $match.Groups[4].Value;

		$name

		if($name -match $chap_page_reg)
		{
			$freq = $matches[1]
			$couple = $matches[2]
			$chap = $matches[3]
			$managed = $matches[4]
			$page = $matches[5]
			$sub_page = $matches[6]

			if($chap.StartsWith("n")) { $chap = $chap.Replace("n", "Neg") }
			if($couple -eq "c") { $couple = "Coupled" } else { $couple = "Uncoupled" }

			if($book_params -match $opts_reg)
			{
				$dim = $matches[1]
				$type = $matches[2]
				$min = $matches[3]
				$delta = $matches[4]
				$quant = $matches[5]
				$quant_p = $matches[6]

				if($managed -eq "sm") {
					$chapname = "ManagedChapter$($chap)"
				} else {
					$chapname = "Chapter$($chap)"
				}
				$pagenum = "Page$($page)_$($sub_page)"

				$page_class = [string]::Format($page_template, $freq, $couple, $chapname, $pagenum, $dim, $length_list, $type, $min, $delta, $quant, $quant_p, $quant_list);

				#Write-Host $page_class
				$dir = [IO.Path]::Combine($output_dir, "Stereo$($freq)", $couple, $chapname)

				if(-not [IO.Directory]::Exists($dir)) { [IO.Directory]::CreateDirectory($dir) }
				$file = [IO.Path]::Combine($dir, "$($pagenum).cs")
				$file
				[IO.File]::WriteAllText($file, $page_class);
			}
		}
	}
}


function Generate-Huffman()
{
	param (
		[string]$PageContent
	)

	$huffman_matches = [Regex]::Matches($PageContent, $huffman_regex, [System.Text.RegularExpressions.RegexOptions]::Singleline)
	foreach($match in $huffman_matches)
	{
		$name = $match.Groups[1].Value
		$length_list = $match.Groups[2].Value;
		$book_params = $match.Groups[3].Value;

		$name

		if($name -match $huffman_name_regex)
		{
			$freq = $matches[1]
			$couple = $matches[2]
			$chap = $matches[3]
			$managed = $matches[4]
			$size = $matches[5]

			if($chap.StartsWith("n")) { $chap = $chap.Replace("n", "Neg") }
			if($couple -eq "c") { $couple = "Coupled" } else { $couple = "Uncoupled" }

			#Map correct casing
			$size = @{
				"single"="Single";
				"short" = "Short";
				"long" = "Long"
			}[$size];

			if($book_params -match $opts_reg)
			{
				$dim = $matches[1]
				$type = $matches[2]
				$min = $matches[3]
				$delta = $matches[4]
				$quant = $matches[5]
				$quant_p = $matches[6]

				if($managed -eq "sm") {
					$chapname = "ManagedChapter$($chap)"
				} else {
					$chapname = "Chapter$($chap)"
				}

				$classname = "$($chapname)$($size)"

				$page_class = [string]::Format($page_template, $freq, $couple, $chapname, $classname, $dim, $length_list, $type, $min, $delta, $quant, $quant_p, "null");

				#Write-Host $page_class
				$dir = [IO.Path]::Combine($output_dir, "Stereo$($freq)", $couple, $chapname)

				if(-not [IO.Directory]::Exists($dir)) { [IO.Directory]::CreateDirectory($dir) }
				$file = [IO.Path]::Combine($dir, "$($classname).cs")
				$file
				[IO.File]::WriteAllText($file, $page_class);
			}
		}
	}
}

function Generate-From()
{
	param (
		[string]$URL
	)

	$Page = Invoke-WebRequest -Method Get -Uri $URL
	
	Generate-Books -PageContent $Page.RawContent
	Generate-Huffman -PageContent $Page.RawContent
}

foreach($url in $urls)
{
	Generate-From -URL $url
}