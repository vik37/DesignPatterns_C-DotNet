using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDP_UdemyDesignPatterns_ConsoleApp.TextFormatting
{
    public class BetterFormaterText
    {
        private string planeText;
        private List<TextRange> formatting = new List<TextRange>();
        public BetterFormaterText(string planeText)
        {
            this.planeText = planeText;
        }
        // Return Flyweight object
        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange { Start = start, End = end };
            formatting.Add(range);
            return range;
        }
        public class TextRange
        {
            public int Start, End;
            public bool Capitalize, Bold, Italic;
            public bool Covers(int position)
            {
                return position >= Start && position <= End;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < planeText.Length; i++)
            {
                var c = planeText[i];
                foreach (var range in formatting)
                {
                    if(range.Covers(i) && range.Capitalize)
                    {
                        c = char.ToUpper(c);
                    }
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
