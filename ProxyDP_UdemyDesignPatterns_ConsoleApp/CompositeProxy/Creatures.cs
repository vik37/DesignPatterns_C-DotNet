using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.CompositeProxy
{
    public class Creatures
    {
        private readonly int size;
        private byte[] age;
        private int[] x, y;
        public Creatures(int size)
        {
            this.size = size;
            age = new byte[size];
            x = new int[size];
            y = new int[size];
        }

        // This struct is Placehoplder allows to access particuar element.
        // Proxy Pattern: Provide a placeholder for another object to control access.
        public struct CreatureProxy
        {
            private readonly Creatures creatures;
            private readonly int index;

            public CreatureProxy(Creatures creatures, int index)
            {
                this.creatures = creatures;
                this.index = index;
            }
            // Refferencece into arrays defined above.
            public ref byte Age => ref creatures.age[index];
            public ref int X => ref creatures.x[index];
            public ref int Y => ref creatures.y[index];
        }
        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (int pos = 0; pos < size; ++pos)
            {
                yield return new CreatureProxy(this, pos);
            }
        }
    }
}
