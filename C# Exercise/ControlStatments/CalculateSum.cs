using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatments
{
    public class CalculateSum
    {
        public void calSum()
        {
            //* adds numbers between 1 upto 10
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
        }
    }
}