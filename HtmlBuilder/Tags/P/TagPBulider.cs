using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.P
{
 public   class TagPBulider
    {
        public TagPBulider AppendElement(IRenderable renderable)
        {
            children.Add(renderable);
            return this;
        }
        private string _id;
        private List<IRenderable> children = new List<IRenderable>();

        private TagPBulider()
        {

        }
        public static TagPBulider Create()
        {
            return new TagPBulider();
        }

        public TagPBulider WithId(string id)
        {
            _id = id;
            return this;
        }
        public TagP Build()
        {
            return new TagP(_id, children);
        }

    }
}
