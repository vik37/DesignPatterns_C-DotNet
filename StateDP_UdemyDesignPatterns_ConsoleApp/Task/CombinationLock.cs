using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class CombinationLock
    {
        private readonly int[] combination;
        public string Status = "LOCKED";
        private int count = 0;
        public CombinationLock(int[] combination)
        {
            this.combination = combination;
        }
        public void EnterDigit(int digit)
        {
            if(count == 0) Status = "";

            
            if(count + 1 == combination.Length && digit == combination[count])
            {
                Status = "OPEN";
            }
            else if (digit == combination[count])
            {
                this.Status += digit.ToString();
                ++count;
            }
            else
            {
                Status = "ERROR";
            }
        }
    }
}
