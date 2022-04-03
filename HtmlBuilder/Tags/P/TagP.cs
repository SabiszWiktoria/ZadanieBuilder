using HtmlBuilder.Tags.P;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    
  public  class TagP: IRenderable
    {
        private const string name = "p";
   
        private string id;
     


        public string GetOpening()
        {
            StringBuilder tag =  new StringBuilder($@"<{name}");
            if(!string.IsNullOrEmpty(id)) tag.Append($@" id='{id}'");
            tag.Append(">");

            return tag.ToString();
        }
        public string GetClosing()
        {
            string tag = $@"</{ name}>";
            return tag;
        }
        private List<IRenderable> children;

        public TagP(string id, List<IRenderable> children)
        {
           
            this.id = id;
            this.children = children;
        }

        public static TagPBulider New()
        {
           return TagPBulider.Create();
        }
     

        public string Render()
        {
            StringBuilder rendered = new StringBuilder();
            rendered.Append(GetOpening());
            foreach (var child in children)
            {
                rendered.Append(child.Render());
            }
            rendered.Append(GetClosing());
            return rendered.ToString();
        }

    }
}
