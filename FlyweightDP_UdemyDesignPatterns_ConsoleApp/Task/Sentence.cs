using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Sentence
    {
        private string plainText;
        private WordToken wordTokens = new WordToken();
        public Sentence(string plainText)
        {
            this.plainText = plainText;
        }
        public WordToken this[int index]
        {
            get
            {
                var token = new WordToken { Index = index };
                wordTokens = token;
                return token;
            }
        }
        public class WordToken
        {
            public bool Capitalize;
            public int Index;
            public bool Cover(int position)
            {
                return Index == position;
            }
        }
        public override string ToString()
        {
            string[] texts = plainText.Split(" ");
            var sb = new StringBuilder();
            
            for (int i = 0; i < texts.Length; i++)
            {
                if (wordTokens.Cover(i) && wordTokens.Capitalize)
                {
                    texts[i] = texts[i].ToUpper();
                }
                sb.Append(texts[i] + " ");
            }
            return sb.ToString();
        }
        
    }
}
