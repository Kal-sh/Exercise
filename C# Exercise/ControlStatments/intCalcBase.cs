using System;

namespace ControlStatments
{
    public class intCalcBase
    {
        //* check if a number is divisible by 2 or 3
        public void Calc()
        {
            Console.Write("input value A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput value B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))

            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }
    }
}