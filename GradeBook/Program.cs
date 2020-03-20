using System;
using System.Collections.Generic;

namespace GradeBook
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var book = new DiscBook("My grade book");
            EnterGrade(book);

            var stats = book.GetStats();
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The Highest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");

        }

        private static void EnterGrade(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Please enter the grade or press q to see the statistics");
                var value = Console.ReadLine();

                if (value == "q")
                {
                    break;
                }
                try
                {
                    book.AddGrade(double.Parse(value))
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
