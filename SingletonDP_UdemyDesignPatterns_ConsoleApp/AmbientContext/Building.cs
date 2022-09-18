using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.AmbientContext
{
    public class Building
    {
        public List<Wall> Walls = new List<Wall>();
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var wall in Walls)
            {
                sb.AppendLine(wall.ToString());
                
            }
            return sb.ToString();
        }
    }
}
