using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class ClassTrueAndFalse:Question
    {
        public override void QuestionType()
        {
            Console.WriteLine("Please Enter Body Of Question:");
            Body = Console.ReadLine();
            Console.WriteLine("please Enter The Mark Of Question:");
            Mark = int.Parse (Console.ReadLine());
            answers.Add("True");
            answers.Add("False");
            Console.WriteLine("Enter Right Answer 1 For true and 2 For False:");
            RightAnswer.AnsId=int.Parse (Console.ReadLine());
            RightAnswer.AnsText = answers[RightAnswer.AnsId].ToString();
        }

            
    }
}
