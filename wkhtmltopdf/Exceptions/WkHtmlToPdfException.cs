using System;

namespace wkhtmltopdf
{
    class WkHtmlToPdfException : Exception
    {
        public WkHtmlToPdfException(string message) : base(message)
        {

        }
    }
}
