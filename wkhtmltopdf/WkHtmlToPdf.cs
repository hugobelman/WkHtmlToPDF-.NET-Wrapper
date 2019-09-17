using System.Diagnostics;
using System.IO;
using System.Text;

namespace hugobelman.wkhtmltopdf
{
    public class WkHtmlToPdf
    {
        private readonly string executablePath = "wkhtmltopdf.exe";
        public WkHtmlToPdf()
        {
            CheckIfExecutableExists();
        }

        public WkHtmlToPdf(string executablePath)
        {
            this.executablePath = executablePath;
            CheckIfExecutableExists();
        }

        private void CheckIfExecutableExists()
        {
            if (!File.Exists(executablePath))
            {
                throw new WkHtmlToPdfException("WkHtmlToPdf executable doesn't exist");
            }
        }

        public void ConvertHTMLToPDF(string inputHtmlFilePathOrUrl, string outputPdfFilePath)
        {
            var parameters = $"{inputHtmlFilePathOrUrl} {outputPdfFilePath}";

            ExecuteWithParameters(parameters);
        }

        public void ConvertHTMLToPDF(string inputHtmlFilePathOrUrl, string outputPdfFilePath, WkHtmlToPdfOptions options)
        {
            var parametersStringBuilder = new StringBuilder();
            var stringParams = WkHtmlToPdfOptionsToStringParameters(options);

            parametersStringBuilder.Append(stringParams);
            parametersStringBuilder.Append($"{inputHtmlFilePathOrUrl} {outputPdfFilePath}");

            ExecuteWithParameters(parametersStringBuilder.ToString());
        }

        private string WkHtmlToPdfOptionsToStringParameters(WkHtmlToPdfOptions options)
        {
            var paramsStringBuilder = new StringBuilder();

            paramsStringBuilder.Append($"--encoding {options.Encoding.WebName} ");
            paramsStringBuilder.Append($"--copies {options.Copies} ");
            paramsStringBuilder.Append($"--dpi {options.Dpi} ");
            paramsStringBuilder.Append($"--image-dpi {options.Dpi} ");
            paramsStringBuilder.Append($"--image-quality {options.Dpi} ");

            if (options.NoCollate) paramsStringBuilder.Append("--no-collate ");
            if (options.Grayscale) paramsStringBuilder.Append("--grayscale ");
            if (options.LowQuality) paramsStringBuilder.Append("--lowquality ");
            if (options.NoBackground) paramsStringBuilder.Append($"--no-background ");
            if (options.EnableForms) paramsStringBuilder.Append($"--enable-forms ");
            if (options.NoImages) paramsStringBuilder.Append($"--no-images ");
            if (options.DisableLinks) paramsStringBuilder.Append($"--disable-internal-links --disable-external-links ");
            if (options.DisableJavascript) paramsStringBuilder.Append("--disable-javascript ");

            string orientationParam = GetOrientationParam(options.PageOrientation);
            paramsStringBuilder.Append(orientationParam);

            string marginParams = GetMarginParams(options.Margin);
            paramsStringBuilder.Append(marginParams);

            string pageSizeParam = GetPageSizeParam(options.PageSize);
            paramsStringBuilder.Append(pageSizeParam);

            string headerParams = GetHeaderParams(options.Header);
            paramsStringBuilder.Append(headerParams);

            string footerParams = GetFooterParams(options.Footer);
            paramsStringBuilder.Append(footerParams);

            return paramsStringBuilder.ToString();
        }

        private void ExecuteWithParameters(string parameters)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(executablePath, $"--quiet {parameters}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            Process process = Process.Start(startInfo);
            process.WaitForExit();

            if (process.ExitCode > 0)
            {
                string messageError = process.StandardError.ReadToEnd();
                throw new WkHtmlToPdfException(messageError);
            }
        }

        private string GetMarginParams(WkHtmlToPdfMargin margin)
        {
            var paramsStringBuilder = new StringBuilder();

            if (margin != null)
            {
                paramsStringBuilder.Append($"--margin-bottom {margin.Bottom} ");
                paramsStringBuilder.Append($"--margin-left {margin.Left} ");
                paramsStringBuilder.Append($"--margin-right {margin.Rigth} ");
                paramsStringBuilder.Append($"--margin-top {margin.Top} ");
            }

            return paramsStringBuilder.ToString();
        }

        private string GetPageSizeParam(PaperSize pageSize)
        {
            string pageSizeString;

            switch (pageSize)
            {
                case PaperSize.A0:
                    pageSizeString = "A0";
                    break;

                case PaperSize.A1:
                    pageSizeString = "A1";
                    break;

                case PaperSize.A2:
                    pageSizeString = "A2";
                    break;

                case PaperSize.A3:
                    pageSizeString = "A3";
                    break;

                case PaperSize.A4:
                    pageSizeString = "A4";
                    break;

                case PaperSize.A5:
                    pageSizeString = "A5";
                    break;
                case PaperSize.A6:
                    pageSizeString = "A6";
                    break;

                case PaperSize.A7:
                    pageSizeString = "A7";
                    break;

                case PaperSize.A8:
                    pageSizeString = "A8";
                    break;

                case PaperSize.A9:
                    pageSizeString = "A9";
                    break;

                case PaperSize.B0:
                    pageSizeString = "B0";
                    break;

                case PaperSize.B1:
                    pageSizeString = "B1";
                    break;

                case PaperSize.B2:
                    pageSizeString = "B2";
                    break;

                case PaperSize.B3:
                    pageSizeString = "B3";
                    break;

                case PaperSize.B4:
                    pageSizeString = "B4";
                    break;

                case PaperSize.B5:
                    pageSizeString = "B5";
                    break;
                case PaperSize.B6:
                    pageSizeString = "B6";
                    break;

                case PaperSize.B7:
                    pageSizeString = "B7";
                    break;

                case PaperSize.B8:
                    pageSizeString = "B8";
                    break;

                case PaperSize.B9:
                    pageSizeString = "B9";
                    break;

                case PaperSize.B10:
                    pageSizeString = "B10";
                    break;

                case PaperSize.CSE:
                    pageSizeString = "C5E";
                    break;

                case PaperSize.COMM10E:
                    pageSizeString = "Comm10E";
                    break;

                case PaperSize.DLE:
                    pageSizeString = "DLE";
                    break;

                case PaperSize.EXECUTIVE:
                    pageSizeString = "Executive";
                    break;

                case PaperSize.FOLIO:
                    pageSizeString = "Folio";
                    break;

                case PaperSize.LEDGER:
                    pageSizeString = "Ledger";
                    break;

                case PaperSize.LEGAL:
                    pageSizeString = "Legal";
                    break;

                case PaperSize.LETTER:
                    pageSizeString = "Letter";
                    break;

                default:
                    pageSizeString = "Tabloid";
                    break;
            }

            return $"--page-size {pageSizeString} ";
        }

        private string GetOrientationParam(Orientation orientation)
        {
            string orientationString;

            if (orientation == Orientation.PORTRAIT) orientationString = "Portrait";
            else orientationString = "Landscape";

            return $"--orientation {orientationString} ";
        }

        private string GetHeaderParams(WkHtmlToPdfHeaderFooter header)
        {
            var paramsStringBuilder = new StringBuilder();

            if (header != null)
            {
                if (header.HtmlUrl != null) paramsStringBuilder.Append($"--header-html \"{header.HtmlUrl}\" ");
                if (header.Center != null) paramsStringBuilder.Append($"--header-center \"{header.Center}\" ");
                if (header.Left != null) paramsStringBuilder.Append($"--header-left \"{header.Left}\" ");
                if (header.Right != null) paramsStringBuilder.Append($"--header-right \"{header.Right}\" ");
                if (header.Spacing != 0.0) paramsStringBuilder.Append($"--header-spacing \"{header.Spacing}\" ");
                if (header.FontSize != 12.0) paramsStringBuilder.Append($"--header-font-size \"{header.FontSize}\" ");
                if (header.FontName != null) paramsStringBuilder.Append($"--header-font-name \"{header.FontName}\" ");
            }

            return paramsStringBuilder.ToString();
        }

        private string GetFooterParams(WkHtmlToPdfHeaderFooter footer)
        {
            var paramsStringBuilder = new StringBuilder();

            if (footer != null)
            {
                if (footer.HtmlUrl != null) paramsStringBuilder.Append($"--footer-html \"{footer.HtmlUrl}\" ");
                if (footer.Center != null) paramsStringBuilder.Append($"--footer-center \"{footer.Center}\" ");
                if (footer.Left != null) paramsStringBuilder.Append($"--footer-left \"{footer.Left}\" ");
                if (footer.Right != null) paramsStringBuilder.Append($"--footer-right \"{footer.Right}\" ");
                if (footer.Spacing != 0.0) paramsStringBuilder.Append($"--footer-spacing \"{footer.Spacing}\" ");
                if (footer.FontSize != 12.0) paramsStringBuilder.Append($"--footer-font-size \"{footer.FontSize}\" ");
                if (footer.FontName != null) paramsStringBuilder.Append($"--footer-font-name \"{footer.FontName}\" ");
            }

            return paramsStringBuilder.ToString();
        }
    }
}
