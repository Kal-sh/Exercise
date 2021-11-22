using System;

namespace ControlStatments
{
    public class EvenNumbersBase
    {
        // print even numbers between 0 and 100
        public void evenNum()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i.ToString());
                }
            }
        }
    }
}