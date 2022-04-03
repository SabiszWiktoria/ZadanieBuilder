using HtmlBuilder.Tags.H;
using HtmlBuilder.Tags.HtmlString;
using System;

namespace HtmlBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             
            string head;
            string body;
            
            TagLink link = TagLink.New()
                .WithHref("style.css")
                .WithRel("stylesheet")
                .Build();
            TagA a = TagA.New()
                .WithHref("https://www.someurl.com")
                .WithValue("link text")
                .Build();
            TagP p = TagP.New()
                  .AppendElement(a)
                  .AppendElement(new HtmlString("sample text"))
                  .Build();
            TagDiv div2 = TagDiv.New()
                .WithId("div2")
                .AppendElement(p)
                .Build();
            TagImg img = TagImg.New()
                .WithSrc("picture.jpg")
                .WithAlt("some alt text")
                .Build();
            TagH h1 = TagH.New()
               .AppendElement(new HtmlString("Some nice header"))
               .Build();
            TagP p2 = TagP.New()
                .AppendElement(new HtmlString("Some nice paragraph"))
                .Build();
            TagDiv Div1 = TagDiv.New()
                .WithId("div1")
                .AppendElement(h1)
                .AppendElement(p)
                .AppendElement(p2)
                .AppendElement(div2)
                .AppendElement(img)
                .AppendElement(TagDiv.New()
                .WithId("div3")
                .AppendElement(TagDiv.New()
                .WithId("div4")
                .Build())
                .Build())
                .Build();


            body = Div1.Render();
            head = link.Tag();
            string script = $@"
            <!DOCTYPE html>
                <html>
                  <head>
                    <meta charset='utf - 8'>
                        {head}
                    < title > My test page</ title >
                  </ head >
                  < body >
                     {body}
                  </ body >
                  <footer>
                
                  </footer>
             </ html > ";

            Console.WriteLine(script);

    }
}
}
