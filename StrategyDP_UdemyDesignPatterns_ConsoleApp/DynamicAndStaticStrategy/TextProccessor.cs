using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Enums;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy
{
    public class TextProccessor<LS> where LS : IListStrategy, new()  //<LS> its part of static strategy
    {
        private StringBuilder sb = new StringBuilder();
        #region Static Strategy
        private IListStrategy listStrategy = new LS();
        #endregion

        #region Dinamyc Strategy
        //private IListStrategy listStrategy;
        //public void SetOutpuFormat(OutputFormat format)
        //{
        //    switch (format)
        //    {
        //        case OutputFormat.Markdown:
        //            listStrategy = new MarkdownListStrategy();
        //            break;
        //        case OutputFormat.Html:
        //            listStrategy = new HtmlListStrategy();
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(format), format, null);
        //    }
        //}
        #endregion

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(sb);
            foreach (var item in items)
                    listStrategy.AddListItem(sb, item);
            listStrategy.End(sb);
        }
        public override string ToString()
        {
            return sb.ToString();
        }
        public StringBuilder Clear()
        {
            return sb.Clear();
        }
    }
}
