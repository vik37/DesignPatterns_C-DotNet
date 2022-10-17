using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy
{
    public class HtmlListStrategy : IListStrategy
    {       
        public void Start(StringBuilder sb)
        {
            sb.AppendLine("<ul>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine("</ul>");
        }
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($"   <li>{item}</li>");
        }

    }
}
