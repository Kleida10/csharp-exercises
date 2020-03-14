using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Question
    {
        public string Questions { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
       
        public Question (string question, string correctAnswer)
        {
           Questions = question;
           CorrectAnswer = correctAnswer;
        }
       
       
    }
}
