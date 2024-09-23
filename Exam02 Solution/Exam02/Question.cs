using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Question 
    {

        public string Header { get; set; }
        public string Body { get; set; }
        private int mark;
        public Question()
        {
            
        }

        public int Mark
        {
            get { return mark; }
            set {
                if (value < 0)
                    throw new Exception("Mark Must Be More Than 0 ");
                    mark = value;

                 }
        }
        public ArrayList answers = new ArrayList();

        public Answers RightAnswer = new Answers();

        public abstract void QuestionType();
        

        
        
        

       

       
       
















    }
         
          
        
        

        



    
}
