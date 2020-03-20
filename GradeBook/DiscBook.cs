using System.IO;

namespace GradeBook
{
    partial class Program
    {
        public class DiscBook : Book
        {
            public DiscBook(string name) : base(name)
            {
            }

            public override void AddGrade(double grade)
            {
                using (var writer = File.AppendText($"{Name}.txt"))
                {
                    writer.Write(grade);
                }
            }

            public override Statistics GetStats()
            {
                var result = new Statistics();

                using (var reader = File.OpenText($"{Name}.txt"))
                {
                   var line =  reader.ReadLine();
                    while(line != null)
                    {
                        var number = double.Parse(line);
                        result.Add(number);
                        line = reader.ReadLine();
                    }
                }

                    return result;
            }
        }
    }
}
