namespace wkhtmltopdf
{
    public class WkHtmlToPdfMargin
    {
        private float top = 0;
        private float bottom = 0;
        private float left = 10.0F;
        private float rigth = 10.0F;

        public float Top { get => top; set => top = value; }
        public float Bottom { get => bottom; set => bottom = value; }
        public float Left { get => left; set => left = value; }
        public float Rigth { get => rigth; set => rigth = value; }

        public WkHtmlToPdfMargin()
        {

        }

        public WkHtmlToPdfMargin(float margin)
        {
            this.top = margin;
            this.bottom = margin;
            this.left = margin;
            this.rigth = margin;
        }

        public WkHtmlToPdfMargin(float top, float bottom, float left, float rigth)
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Rigth = rigth;
        }

        public WkHtmlToPdfMargin(float bottom, float top)
        {
            this.Bottom = bottom;
            this.Top = top;
        }
    }
}
