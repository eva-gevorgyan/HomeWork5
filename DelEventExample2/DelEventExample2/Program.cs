using System.Diagnostics.Metrics;

namespace DelEventExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.CountChange += new Del(Counter_CountChanged);

            Console.WriteLine("Starting count: 0");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == '+')
                {
                    counter.Increment();
                }
                else if (key.KeyChar == '-')
                {
                    counter.Decrement();
                }
            }
        }

        static void Counter_CountChanged(int value)
        {
            Console.WriteLine(" " + value);
        }
    }
}