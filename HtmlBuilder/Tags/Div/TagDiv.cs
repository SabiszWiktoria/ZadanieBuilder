using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{

    public interface ISelfClosableTag
    {
        string GetSelfClosing();
    }

    public interface IClosableTag
    {
        string GetOpening();
        string GetClosing();
    }

    public interface IRenderable
    {
        string Render();
    }
    public class TagDiv : IRenderable //: IClosableTag, ISelfClosableTag
    {
        private const string name = "div";
        private string id;
        private List<IRenderable> children;

        public TagDiv(string id, List<IRenderable> children)
        {
            this.id = id;
            this.children = children;
        }

        public static TagDivBulider New()
        {
            return TagDivBulider.Create();
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

        private string GetOpening()
        {
            StringBuilder tag = new StringBuilder();
            tag.Append($@"<{name}");
            if (!string.IsNullOrEmpty(id)) tag.Append($" id='{id}'");
            tag.Append($@">");
            return tag.ToString();
        }

        private string GetClosing()
        {
            return $@"</{ name}>";
        }

        private string GetSelfClosing()
        {
            return $@"<{name} id='{id}' />";
        }
    }
}
