using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
 public   class TagA:IRenderable
    {
        public string name = "a";
        
        public string href;
        public string value;

        public static ISpecifyHref New()
        {
            return TagABulider.Create();
        }
        public string Render()
        {
            return Tag();
        }

        public string Tag()
        {
            string tag = $@"< {name} href='{href}'  >{value}</{name}>";
            return tag;
        }
    }
}
