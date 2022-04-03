using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.HtmlString
{
    public class HtmlString: IRenderable
    {
        private string value;

        public HtmlString(string value)
        {
            this.value = value;
        }

        public string Render()
        {
            return value;
        }
    }
}
