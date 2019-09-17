using System.Text;

namespace hugobelman.wkhtmltopdf
{
    public enum Orientation { LANDSCAPE, PORTRAIT }

    public enum PaperSize { A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, B0, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, CSE, COMM10E, DLE, EXECUTIVE, FOLIO, LEDGER, LEGAL, LETTER, TABLOID }

    public class WkHtmlToPdfOptions
    {
        private WkHtmlToPdfHeaderFooter footer = new WkHtmlToPdfHeaderFooter();
        private WkHtmlToPdfHeaderFooter header = new WkHtmlToPdfHeaderFooter();
        private Encoding encoding = Encoding.UTF8;
        private WkHtmlToPdfMargin margin = new WkHtmlToPdfMargin();
        private Orientation pageOrientation = Orientation.PORTRAIT;
        private PaperSize pageSize = PaperSize.A4;
        private bool noCollate = false;
        private bool grayscale = false;
        private bool lowQuality = false;
        private bool noBackground = false;
        private bool enableForms = false;
        private bool noImages = false;
        private bool disableLinks = false;
        private bool disableJavascript = false;
        private int dpi = 96;
        private int copies = 1;
        private int imageDpi = 600;
        private int imageQuality = 94;

        public WkHtmlToPdfHeaderFooter Footer { get => footer; set => footer = value; }
        public WkHtmlToPdfHeaderFooter Header { get => header; set => header = value; }
        public Encoding Encoding { get => encoding; set => encoding = value; }
        public WkHtmlToPdfMargin Margin { get => margin; set => margin = value; }
        public Orientation PageOrientation { get => pageOrientation; set => pageOrientation = value; }
        public PaperSize PageSize { get => pageSize; set => pageSize = value; }
        public bool NoCollate { get => noCollate; set => noCollate = value; }
        public bool Grayscale { get => grayscale; set => grayscale = value; }
        public bool LowQuality { get => lowQuality; set => lowQuality = value; }
        public bool NoBackground { get => noBackground; set => noBackground = value; }
        public bool EnableForms { get => enableForms; set => enableForms = value; }
        public bool NoImages { get => noImages; set => noImages = value; }
        public bool DisableLinks { get => disableLinks; set => disableLinks = value; }
        public bool DisableJavascript { get => disableJavascript; set => disableJavascript = value; }
        public int Dpi { get => dpi; set => dpi = value; }
        public int Copies { get => copies; set => copies = value; }
        public int ImageDpi { get => imageDpi; set => imageDpi = value; }
        public int ImageQuality { get => imageQuality; set => imageQuality = value; }

        public WkHtmlToPdfOptions()
        {
            
        }
    }
}