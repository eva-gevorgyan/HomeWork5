using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelEventExample2
{
    public delegate void Del(int value);
    internal class Counter
    {
        public int count = 0;

        public event Del CountChange;
        public void PrintCountChanged(int value)
        {
            if (CountChange != null)
            {
                CountChange(value);
            }
        }
        public void Increment()
        {
            count++;
            PrintCountChanged(count);
        }
        public void Decrement()
        {
            count--;
            PrintCountChanged(count);
        }
    }
}
