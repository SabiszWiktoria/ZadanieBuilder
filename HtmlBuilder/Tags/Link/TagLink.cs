using HtmlBuilder.Tags.Link;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
  public  class TagLink
    {
        private const string name = "link";
        public string rel;
        public string href;

        public string Tag()
        {
            string tag = $@"<{name} rel='{rel}' href'{href}'>";
            return tag;
        }
        public static ISpecifyHrefTagH New()
        {
            return TagLinkBuilder.Create();
        }

        
    }
}
