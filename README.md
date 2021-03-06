# WkHtmlToPDF C# Wrapper (.NET Framework) 

A small and easy-to-use wrapper for convert Html files to Pdf files with wkhtmltopdf executable for C# .NET Framework.

## Install

1. Install Nuget Package
```
Install-Package hugobelman.wkhtmltopdf
```
2. Download wkhtmltopdf from [here](https://wkhtmltopdf.org/downloads.html) flavor **MXE (MinGW-w64) win32/win64**
3. Decompress and move wkhtmltox/bin/wkhtmltopdf.exe where your executable is or specify their location in the WkHtmlToPdf object constructor.

## Usage

```C#
var wkHtmlToPdf = new hugobelman.wkhtmltopdf.WkHtmlToPdf();
wkHtmlToPdf.ConvertHTMLToPDF("input.html", "output.pdf");
```

Or

```C#
var wkHtmlToPdf = new hugobelman.wkhtmltopdf.WkHtmlToPdf();
var pdfOptions = new hugobelman.wkhtmltopdf.WkHtmlToPdfOptions();

pdfOptions.Footer.Center = "Test";
pdfOptions.Header.Right = "[page] out of [topage]";
pdfOptions.PageSize = hugobelman.wkhtmltopdf.PaperSize.A4;
pdfOptions.Margin = new hugobelman.wkhtmltopdf.WkHtmlToPdfMargin(5.0f,10.0f,5.0f,5.0f);
pdfOptions.Dpi = 30

wkHtmlToPdf.ConvertHTMLToPDF("google.com", "output.pdf", pdfOptions);
```
## Options

* Dpi
* Copies
* ImageDpi
* ImageQuality
* Footer
* Header
* Margin
* Encoding
* PageOrientation
* PageSize
* NoCollate (Boolean)
* GrayScale (Boolean)
* LowQuality (Boolean)
* NoBackground (Boolean)
* EnableForms (Boolean)
* NoImages (Boolean)
* DisableLinks (Boolean)
* DisableJavascript (Boolean)

In header and footer text string supplied the following variables will be substituted.

   * [page]       Replaced by the number of the pages currently being printed
   * [frompage]   Replaced by the number of the first page to be printed
   * [topage]     Replaced by the number of the last page to be printed
   * [webpage]    Replaced by the URL of the page being printed
   * [section]    Replaced by the name of the current section
   * [subsection] Replaced by the name of the current subsection
   * [date]       Replaced by the current date in system local format
   * [isodate]    Replaced by the current date in ISO 8601 extended format
   * [time]       Replaced by the current time in system local format
   * [title]      Replaced by the title of the of the current page object
   * [doctitle]   Replaced by the title of the output document
   * [sitepage]   Replaced by the number of the page in the current site being converted
   * [sitepages]  Replaced by the number of pages in the current site being converted

## Testing

*Tested with wkhtmltopdf.exe MXE (MinGW-w64) win32 / win64 Stable v 0.12.5*

## Licence

This library is under MIT Licence.
