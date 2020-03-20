using System;
using System.Collections.Generic;


namespace GradeBook
{

    public abstract class Book : NameObject, IBook
    {
        public Book(string name) : base(name)
        {
        }
        public abstract void AddGrade(double grade);

        public abstract Statistics GetStats();
    } 
    public class InMemoryBook: Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }
        public override void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
                grades.Add(grade);
            else
                throw new ArgumentException("Please enter a valid grade");

        }
        public override Statistics GetStats()
        {
            var result = new Statistics();
          

            foreach (var grade in grades)
            {
                result.Add(grade);
               
            }

            return result;
        }

        List<double> grades;

    }
}
