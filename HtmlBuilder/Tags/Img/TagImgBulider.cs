using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{

    public interface ISpecifySrc
    {
        ISpecifyAlt WithSrc(string src);
    }
    public interface ISpecifyAlt
    {
        IImgBuilder WithAlt(string alt);
    }
    public interface IImgBuilder
    {
        TagImg Build();
    }
    class TagImgBulider : ISpecifySrc, ISpecifyAlt, IImgBuilder
    {
        private readonly TagImg _img = new TagImg();
        private TagImgBulider()
        {

        }
        public static ISpecifySrc Create()
        {
            return new TagImgBulider();
        }
        public ISpecifyAlt WithSrc(string src)
        {
            _img.src = src;
            return this;
        }
        public IImgBuilder WithAlt(string alt)
        {
            _img.alt = alt;
            return this;
        }
        public TagImg Build()
        {
            return _img;
        }
    }
}
