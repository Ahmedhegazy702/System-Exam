using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
   public class Subject
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public Exam exam { get; set; }



        public Subject(int _id, string _exam)
        {
            Id = _id;
            Name = _exam;

        }
        int N;
        int Number;
        int Time;
        public void CreateExam()
        {
            

            
            
            Console.WriteLine("Enter Type Of Exam: 1 For Final Exam  Or 2 For Practical Exam :");
            int.TryParse(Console.ReadLine(), out N);
            Console.WriteLine("Enter Time Of Exam in Minutes:");
            int.TryParse(Console.ReadLine(), out Time);
            Console.WriteLine("Enter Number Of Question: ");
            int.TryParse(Console.ReadLine(), out Number );

            switch (N)
            {
               case 1:
                    exam = new FinalExam(Number, Time);
                    exam.CreateExam();
                    break;
                case 2:
                    exam=new PracticalExam(Number,Time);
                    exam.CreateExam();
                    break;

                default:
                    Console.WriteLine("1 For Final Exam  Or 2 For Practical Exam Only");
                    break;



            }

            
            



           


        }

        //public override void ShowExam()
        //{
        //    Exam exam;
        //    Exam exam1;
        //    if(N==1)
        //    {
        //        exam = new FinalExam();
        //        exam.ShowExam();
        //    }
        //    else if(N==2)
        //    {
        //        exam1=new PracticalExam();
        //        exam1.ShowExam();

        //    }
        //}
    }
}
