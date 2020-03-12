using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Questions
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
       
        public Questions (string question, string correctAnswer)
        {
           Question = question;
           CorrectAnswer = correctAnswer;
        }
       
       
    }
}
