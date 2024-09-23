using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
   public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }

        public Question[] Question{ get; set; }

        public abstract void ShowExam();
        public Exam(int _NumOfQuestion, int _TimeOfExam)
        {
            NumberOfQuestion = _NumOfQuestion;
            NumberOfQuestion = _TimeOfExam;
            Question = new Question[NumberOfQuestion];
        }
        public abstract void CreateExam();
    }
}
