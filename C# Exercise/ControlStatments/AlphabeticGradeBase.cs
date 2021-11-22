using System;

namespace ControlStatments
{
    public class AlphabeticGradeBase
    {
        //* Numberic grade to Alphabet
        public void calGrade()
        {
            Console.Write("input grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Wrong input");
            }
            else if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}