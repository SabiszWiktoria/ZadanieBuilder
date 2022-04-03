using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.H
{
    public interface ISpecifyName
    {
        public ITagHBuilder WithId(string id);
    }
    public interface ITagHBuilder
    {
       public TagH Build();
    }
  public  class TagHBuilder: ISpecifyName,ITagHBuilder
    {
        private string _id;
        private Name _name;
        private List<IRenderable> children = new List<IRenderable>();
        public TagHBuilder AppendElement(IRenderable chirdren)
        {
            children.Add(chirdren);
            return this;
        }
        public TagHBuilder()
        {

        }
        public static TagHBuilder Create()
        {
            return new TagHBuilder();
        }
        public ITagHBuilder WithId(string id)
        {
            _id = id;
            return this;
        }
        public TagHBuilder WithName(Name name)
        {
            _name = name;
            return this;
        }
        
        public TagH Build()
        {
            return new TagH(_name, _id, children);
        }




    }
}
