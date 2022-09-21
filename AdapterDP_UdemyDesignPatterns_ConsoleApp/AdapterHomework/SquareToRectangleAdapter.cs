using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterHomework
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private List<int> cash = new List<int>();
        private Square square;
        public int Wdth { get => square.Side; } 

        public int Height { get => square.Side; }

        public SquareToRectangleAdapter(Square Square)
        {
            this.square = Square;
            for (int i = 0; i < 4; i++)
            {
                cash.Add(this.Area());
            }
        }
        public IEnumerable<int> SquarePoints()
        {
            foreach (var item in cash)
            {
                yield return item;
            }
        }
        
    }
}
