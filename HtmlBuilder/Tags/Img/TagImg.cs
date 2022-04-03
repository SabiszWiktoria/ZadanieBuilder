using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
  public  class TagImg:IRenderable
    {
        public string name = "img";
      
        public string src;
        public string alt;
        

        public static ISpecifySrc New()
        {
            return TagImgBulider.Create();
        }

        public string Render()
        {
            return Tag();
        }

        public string Tag()
        {
            string tag = $@"<{name} src='{src}' alt='{alt}'>";
            return tag;
        }

    }
}
