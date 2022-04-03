using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    public interface ISpecifyHref
    {
        ISpecifyValue WithHref(string href);
    }
    public interface ISpecifyValue
    {
        IABuilder WithValue(string alt);
    }
    public interface IABuilder
    {
        TagA Build();
    }


    class TagABulider : ISpecifyHref, ISpecifyValue, IABuilder
        {

            private readonly TagA _a = new TagA();


            private TagABulider()
            {

            }
            public static ISpecifyHref Create()
            {
                return new TagABulider();
            }

            public ISpecifyValue WithHref(string href)
            {
                _a.href = href;
                return this;
            }

            public IABuilder WithValue(string value)
            {
                _a.value = value;
                return this;
            }


            public TagA Build()
            {
                return _a;
            }
        
    }
}
