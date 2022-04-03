using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tests
{
    [TestClass()]
    public class TagImgTests
    {
        [TestMethod()]
        public void TestTagImg()
        {
            TagImg element = TagImg.New()
                .WithSrc("src")
                .WithAlt("alt")
                .Build();
            Assert.AreEqual("<img src='src' alt='alt'>",element.Tag());
        }

        [TestMethod()]
        public void TestTagImgBuilderDender()
        {

            TagImg element = TagImg.New()
                .WithSrc("src")
                .WithAlt("alt")
                .Build();
            Assert.AreEqual("<img src='src' alt='alt'>", element.Render());
        }

        
    }
}