using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Text;
using HtmlBuilder.Tags.HtmlString;

namespace HtmlBuilder.Tests
{
    [TestClass()]
    public class TagDivTests
    {

        [TestMethod()]
        public void TestWithEmpty()
        {
            TagDiv element = TagDiv.New()
                .Build();
            Assert.AreEqual("<div></div>", element.Render());
        }

        [TestMethod()]
        public void TestWithId()
        {
            TagDiv element = TagDiv.New()
                .WithId("test")
                .Build();
            Assert.AreEqual("<div id='test'></div>", element.Render());
        }

        [TestMethod()]
        public void TestWithStringContent()
        {
            TagDiv element = TagDiv.New()
                .AppendElement(new HtmlString("test"))
                .Build();
            Assert.AreEqual("<div>test</div>", element.Render());
        }
    }
}