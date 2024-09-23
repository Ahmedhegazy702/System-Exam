using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
   public class Mcq :Question
    {
       

        public override void QuestionType()
        {
          
            Console.WriteLine("Enter The Body Of Question:");
            Body = Console.ReadLine();
            Console.WriteLine("please Enter The Mark Of Question:");
            Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Choice Of Questions:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please Enter Choice Number {i+1} :");
                answers.Add(Console.ReadLine());    

            }
            Console.WriteLine("Enter Right Answer:");
            RightAnswer.AnsId = int.Parse(Console.ReadLine());
            RightAnswer.AnsText = answers[RightAnswer.AnsId].ToString();
            



        }
 
      
    }
}
