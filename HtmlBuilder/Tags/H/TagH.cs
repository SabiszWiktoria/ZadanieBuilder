using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.H
{
    public enum Name
    {
        h1,
        h2,
        h3,
        h4,
        h5
    }
    public class TagH:IRenderable
    {

        private Name name = Name.h1;
        private string id;
        private List<IRenderable> children = new List<IRenderable>();

        public TagH(Name name, string id,List<IRenderable> children)
        {
            this.name = name;
            this.id = id;
            this.children = children;

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

        private string GetClosing()
        {
           string tag=$@"</{name}>";
            return tag;
        }
        public static TagHBuilder New()
        {
            return TagHBuilder.Create();
        }
        private string GetOpening()
        {
            StringBuilder tag = new StringBuilder($@"<{name}");
            if (!string.IsNullOrEmpty(id)) tag.Append($@" id='{id}'");
            tag.Append(">");
            return tag.ToString();
        }
    }
}
