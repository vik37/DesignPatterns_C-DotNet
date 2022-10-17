using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Interfaces
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}
