using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorDP_UdemyDesignPatterns_ConsoleApp.ArrayBackedProperties
{
    public class Creature : IEnumerable<int>
    {
        private int[] stats = new int[3];
        public int Strength 
        {
            get => stats[0];
            set { stats[0] = value; } 
        }
        public int Agility 
        { 
            get => stats[1]; 
            set => stats[1] = value; 
        }
        public int Intelligence 
        { 
            get =>  stats[2]; 
            set => stats[2] = value; 
        }
        // better this way!
        public double AverageStat => stats.Average();

        // Instead: 
        //public double AverageStat
        //{
        //    get
        //    {
        //        return (Strength + Agility + Intelligence) / 3.0;
        //    }
        //}

        public IEnumerator<int> GetEnumerator()
        {
            return stats.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }

        
    }
}
