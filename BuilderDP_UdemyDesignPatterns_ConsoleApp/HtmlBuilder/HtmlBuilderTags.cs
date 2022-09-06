using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.HtmlBuilder
{
    public class HtmlBuilderTags
    {
        private readonly string RootName;
        HtmlElement root = new HtmlElement();
        public HtmlBuilderTags(string rootName)
        {
            this.RootName = rootName;
            root.Name = rootName;
        }
        public HtmlBuilderTags AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }
        public override string ToString()
        {
            return root.ToString();
        }
        public void Cean()
        {
            root = new HtmlElement() { Name = RootName };
        }
    }
}
