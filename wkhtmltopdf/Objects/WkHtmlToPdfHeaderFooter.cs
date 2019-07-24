namespace hugob.wkhtmltopdf
{
    public class WkHtmlToPdfHeaderFooter
    {
        private string center;
        private string left;
        private string right;
        private string htmlUrl;
        private string fontName;
        private float fontSize = 12.0F;
        private float spacing = 0.0F;

        public string Center { get => center; set => center = value; }
        public string Left { get => left; set => left = value; }
        public string Right { get => right; set => right = value; }
        public string HtmlUrl { get => htmlUrl; set => htmlUrl = value; }
        public string FontName { get => fontName; set => fontName = value; }
        public float FontSize { get => fontSize; set => fontSize = value; }
        public float Spacing { get => spacing; set => spacing = value; }

        public WkHtmlToPdfHeaderFooter()
        {

        }

        public WkHtmlToPdfHeaderFooter(string center, string left, string right) : this(center)
        {
            this.left = left;
            this.right = right;
        }

        public WkHtmlToPdfHeaderFooter(string center, string left, string right, string fontName, float fontSize)
        {
            this.Center = center;
            this.Left = left;
            this.Right = right;
            this.FontName = fontName;
            this.FontSize = fontSize;
        }

        public WkHtmlToPdfHeaderFooter(string htmlUrl)
        {
            this.HtmlUrl = htmlUrl;
        }
    }
}
