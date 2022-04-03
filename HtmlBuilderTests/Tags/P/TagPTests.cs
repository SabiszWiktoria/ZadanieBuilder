using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tests
{
    [TestClass()]
    public class TagPTests
    {
         [TestMethod()]
        public void TestWithEmpty()
        {
            TagP element = TagP.New()
                .Build();
            Assert.AreEqual("<p></p>", element.Render());
        }
        [TestMethod()]
        public void TestWithId()
        {
            TagP element = TagP.New()
                .WithId("test")
                .Build();
            Assert.AreEqual("<p id='test'></p>", element.Render());
        }

    }
}