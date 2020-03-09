using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 3.14;
            // var b = 5.20;
            // var numbers = new[] { 3.14, 4.25, 6.20 };

            var book = new Book("My grade book");
            book.AddGrade(8.2);
            book.AddGrade(3.14);
            book.AddGrade(20.6);
             
            
            var stats = book.GetStats();
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The Highest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average}");


        }
    }
}
