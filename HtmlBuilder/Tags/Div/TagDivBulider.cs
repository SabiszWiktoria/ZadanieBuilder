using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    
 public   class TagDivBulider 
    {
        public TagDivBulider AppendElement(IRenderable renderable)
        {
            children.Add(renderable);
            return this;
        }
        private string _id;
        private List<IRenderable> children = new List<IRenderable>();
        
        private TagDivBulider()
        {

        }
        public static TagDivBulider Create()
        {
            return new TagDivBulider();
        }

        public TagDivBulider WithId(string id)
        {
            _id = id;
            return this;
        }
        public TagDiv Build()
        {
            return new TagDiv(_id, children);
        }


    }
}
