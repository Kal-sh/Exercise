using System;
using System.Collections.Generic;

namespace ArrayEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //* using list
            var numbers = new List<int> { 3, 7, 9, 2, 14, 5 };

            //using Array
            //var numbers = new int[] { 3, 7, 9, 2, 14, 5 };

            /*
            //* length
            Console.WriteLine("lenth: " + numbers.Length);

            //* Indexof() - possition of the array
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: " + index);

            //* clear() - change array value to default from specified stating point and end
            Array.Clear(numbers, 1, 3);
            Console.WriteLine("effect of clear");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //* copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy()");
            foreach (int i in another)
                Console.WriteLine(i);

            //* sort() - arrange in assending order
            Array.Sort(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i);

            //* reverse() - reverse array
            Array.Reverse(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i);

            int[,] gradeArray = { { 88, 55, 93 }, { 82, 43, 66 }, { 24, 67, 98 } };
            int lowGrade = 100;
            foreach (int i in gradeArray)
            {
                if (i < lowGrade)
                {
                    lowGrade = i;
                    Console.WriteLine(lowGrade);
                }
            }
            var x = Console.ReadLine();
            foreach (var i in x)
                if (x == "4")
                {
                    Console.WriteLine("true");
                }
                else { Console.WriteLine("false"); }

            //* list implimentaion
              * add 1 to list
            numbers.Add(1);
            foreach (var i in numbers)
                Console.WriteLine(i);
            //* index of 1
            */
            Console.WriteLine("index of: " + numbers.IndexOf(1));

            //numbers.Clear();
            Console.WriteLine("count: " + numbers.Contains(7));
        }
    }
}