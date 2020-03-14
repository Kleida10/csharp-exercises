using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Quiz
    {
        public List<Question> questions = new List<Question>();

        public void AddQuestion(Question qs)

        {
            questions.Add(qs);
        }

        void Grade(string answer, string correctAnswer)
        {
            if (answer.Length == correctAnswer.Length && answer.ToLower().Contains(correctAnswer.ToLower()))
            {
                 Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

        }


        public void RunQuiz()
        {
            Console.WriteLine("Welcome to Quiz Time! Read the questions carefully. \n" +
                "Good Luck!\n");

            foreach (Question q in questions)
            {
                Console.WriteLine(q.Questions);
                q.Answer = Console.ReadLine();
                Grade(q.Answer, q.CorrectAnswer);
            }
        }

    }
}
