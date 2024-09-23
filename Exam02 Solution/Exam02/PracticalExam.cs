using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class PracticalExam: Exam
    {
        public PracticalExam(int _numberquestion, int _time) : base(_numberquestion, _time)
        {

        }



        public override void CreateExam()
        {
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine("Only Mcq Questions ");
         
                Question question;
                question = new Mcq();
                question.Header = "Mcq Question";
                question.QuestionType();
                Question[i] = question;
            }
        }
        public override void ShowExam()
        {
            int Sum = 0;
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Header:{Question[i].Header} \n Question Number {i + 1}\n Body:{Question[i].Body}");
                for (int l = 0; l < Question[i].answers.Count; l++)
                {
                    Console.Write($"Question Answer:  {Question[i].answers[l]} ");

                }
                Console.WriteLine();
                Console.Write("Enter Your Answer: ");
                int Answer = int.Parse(Console.ReadLine());
                if (Answer == Question[i].RightAnswer.AnsId)
                {
                    Sum += Question[i].Mark;
                }
                Console.WriteLine($"Total Mark={Sum}");

                //Question question3;
                //question3 = new Mcq();


                //Console.WriteLine($" RightAnswer:{question3.RightAnswer}");
            }
        }

        

    }

    
}
