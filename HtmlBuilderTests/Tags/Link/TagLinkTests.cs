using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tests
{
    [TestClass()]
    public class TagLinkTests
    {
        [TestMethod()]
        public void TestLinkBuilder()
        {
            TagLink element = TagLink.New()
                .WithHref("href")
                .WithRel("rel")
                .Build();

                
            Assert.AreEqual("<link rel='rel' href'href'>", element.Tag());
        }

       
    }
}