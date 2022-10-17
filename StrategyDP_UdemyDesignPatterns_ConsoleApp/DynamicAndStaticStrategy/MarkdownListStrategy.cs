using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy
{
    public class MarkdownListStrategy : IListStrategy
    {        
        public void Start(StringBuilder sb)
        {
            
        }
        public void End(StringBuilder sb)
        {
            
        }
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }
    }
}
