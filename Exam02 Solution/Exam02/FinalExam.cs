using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {

        public FinalExam(int _NumberQuestion, int _Time) : base(_NumberQuestion, _Time)
        {

        }


        public override void CreateExam()
        {
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Choose Type of Question{i+1}:  1 for True Or False and 2 for Mcq ");
                int number = int.Parse(Console.ReadLine());
                Question question;

                switch (number)
                {
                    case 1:
                        question = new ClassTrueAndFalse();
                        question.Header = "True Or False Question";
                        question.QuestionType();
                        Question[i] = question;
                        break;
                    case 2:
                        question = new Mcq();
                        question.Header ="Mcq Question";
                        question.QuestionType();
                        Question[i] = question;
                        break;
                    default:
                        Console.WriteLine("Please Enter Only 1 Or 2");
                        break;


                }




            }
        }

        public override void ShowExam()
        {
            int Sum = 0;
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.WriteLine($"Header:{ Question[i].Header} \n Question Number {i + 1}\n Body:{Question[i].Body}" );
                for (int l = 0; l < Question[i].answers.Count; l++)
                {
                    Console.Write($"Question Answer: {Question[i].answers[l]} ");

                }
                
                Console.Write("Enter Your Answer: ");
                int Answer = int.Parse(Console.ReadLine());
                if (Answer == Question[i].RightAnswer.AnsId)
                {
                   Sum += Question[i].Mark;
                }
                Console.WriteLine($"Total Mark ={Sum}");


            }

            //Question question4;
            //question4=new ClassTrueAndFalse();
            //Question question5=new Mcq();
            //Console.WriteLine($"{question4.Header} , {question4.answers} , {question4.Mark} \n {question5.Header} , {question5.answers} , {question5.Mark}");
        }
    }
       

      
    
}
