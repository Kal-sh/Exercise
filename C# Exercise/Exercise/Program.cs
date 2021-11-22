using Exercise.newFolder;
using System;

namespace Exercise
{
    internal class Person : PersonBase
    {
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                firstName = "john",
                lastName = "doe"
            };
            person.Introduction();

            Calculator calc = new Calculator();
            var addResult = calc.Add(2, 4);
            Console.WriteLine("Addition result: " + addResult);

            //* Using static method
            var subResult = Calculator.Subtract(8, 4);
            Console.WriteLine("Subtraction result: " + subResult);

            //* Array
            var numbers = new int[3] { 1, 2, 3 };
            //numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //* Strings
            var fName = "kal";
            var lName = "cheru";
            var fullName = string.Format("my name is {0} {1}", fName, lName);
            Console.WriteLine(fullName);

            var names = new string[3] { "john", "melat", "hanna" };
            var formatNames = string.Join(",", names);
            Console.WriteLine(formatNames);

            //* Verbatim strings
            var text = @"Hi john,
look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}