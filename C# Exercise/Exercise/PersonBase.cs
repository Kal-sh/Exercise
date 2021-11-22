using System;

namespace Exercise
{
    internal class PersonBase
    {
        public string firstName;
        public string lastName;

        public void Introduction()
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }
    }
}