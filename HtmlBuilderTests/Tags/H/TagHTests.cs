using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilder.Tags.H;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags.H.Tests
{
    [TestClass()]
    public class TagHTests
    {

        [TestMethod()]
        public void TestWithName()
        {
            TagH element = TagH.New()
                .WithName(Name.h1)
                .Build();
            Assert.AreEqual("<h1></h1>",element.Render());
        }
        [TestMethod()]
        public void TestWithId()
        {
            TagH element = TagH.New()
                .WithName(Name.h2)
                .WithId("test")
                .Build();
            Assert.AreEqual("<h2 id='test'></h2>", element.Render());
        }
        public void TestEmpty()
        {
            TagH element = TagH.New()
                .Build();
            Assert.AreEqual("<h1></h1>", element.Render());
        }


    }
}