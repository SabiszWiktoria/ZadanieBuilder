using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    class TagInput
    {
      public  enum Typ
        {
            text,
            number,
            submit,
            button,
            checkbox,
            radio,
            pasword
        }
        public string name = "input";
        public string clas;
        public string id;
        public Typ type;
        public string value;
    }
}
