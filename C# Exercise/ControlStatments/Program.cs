using System;

namespace ControlStatments
{
    internal class Program
    {
        public class AlphabeticGrade : AlphabeticGradeBase
        {
        }

        public class intCalc : intCalcBase
        {
        }

        public class EvenNumbers : EvenNumbersBase
        {
        }

        private static void Main(string[] args)
        {
            /*
             * check if the input have value 3
             *
            var a = Console.ReadLine();
            Console.WriteLine(a.Contains("3"));
            */

            //* loops

            // var name = "kaleab cherinet";

            /*
            //* for loop

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */

            /*
            //* foreach loop

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            */

            /*
            //* grade calculator
            AlphabeticGrade g = new AlphabeticGrade();
            g.calGrade();
            */

            /*
            //* sum calculator
            CalculateSum class1 = new CalculateSum();
            class1.calSum();
            */

            /*
            //* integer cal
            intCalc calculate = new intCalc();
            calculate.Calc();
            */

            /*
            //* Even Number 0 to 100
            EvenNumbers evenNumbers = new EvenNumbers();
            evenNumbers.evenNum();
            */
        }
    }
}