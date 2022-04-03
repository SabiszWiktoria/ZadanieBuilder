using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.Link
{
    public interface ISpecifyHrefTagH
    {
        public ISpecifyRelTagH WithHref(string href);
    }
    public interface ISpecifyRelTagH
    {
        public ITagLinkBuilderTagH WithRel(string rel);
    }
    public interface ITagLinkBuilderTagH
    {
        public TagLink Build();
    }
    public class TagLinkBuilder : ISpecifyRelTagH, ISpecifyHrefTagH, ITagLinkBuilderTagH
    {
        private readonly TagLink _tagLink = new TagLink();
        public TagLink Build()
        {
            return _tagLink;
        }

        public ISpecifyRelTagH WithHref(string href)
        {
            _tagLink.href = href;
            return this;
        }

        public ITagLinkBuilderTagH WithRel(string rel)
        {
            _tagLink.rel = rel;
            return this;
        }
        public static ISpecifyHrefTagH Create()
        {
            return new TagLinkBuilder();
        }
    }
}
