using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10, "C#");
            sub.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You wan To Start Exam Now(Y|N)");
            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub.exam.ShowExam();
                Console.Clear();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
            
        }
    }
}