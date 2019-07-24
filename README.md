# WkHtmlToPDF C# Wrapper

A small and easy-to-use C# wrapper for wkhtmltopdf executable.

## Install Nuget package

```
Install-Package hugob.wkhtmltopdf
```

## Usage

**¡Needs the wkhtmltopdf executable! [Download here](https://wkhtmltopdf.org/downloads.html)**

Tested with wkhtmltopdf.exe MXE (MinGW-w64) Stable 0.12.5 win32 / win64

```
var wkHtmlToPdf = new hugob.wkhtmltopdf.WkHtmlToPdf();
wkHtmlToPdf.ConvertHTMLToPDF("input.html", "output.pdf");
```

Or

```
var wkHtmlToPdf = new hugob.wkhtmltopdf.WkHtmlToPdf();
var pdfOptions = new hugob.wkhtmltopdf.WkHtmlToPdfOptions();

pdfOptions.Footer.Center = "Test";
pdfOptions.Header.Right = "[page] out of [topage]";
pdfOptions.PageSize = hugob.wkhtmltopdf.PaperSize.LETTER;
pdfOptions.Margin = new hugob.wkhtmltopdf.WkHtmlToPdfMargin(25.4F);
pdfOptions.Dpi = 300;

wkHtmlToPdf.ConvertHTMLToPDF("input.html", "output.pdf", pdfOptions);
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

## Licence

This library is under MIT Licence.
