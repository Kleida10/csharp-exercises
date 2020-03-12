using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Questions> questions = new List<Questions>();
             static List<Questions> AddingQuestions()
            {
                List<Questions> questions = new List<Questions>();

                MultipleChoice q1 = new MultipleChoice("How many angles does a rectangle have?'\n' A. Only 1 '\n' B. It has 2'\n' C. It has 3", "C");
                questions.Add(q1);

                Checkbox q2 = new Checkbox("Multiple Choice'\n Which city/ies is in South America?'\n' A. Brazil'\n' B. Rio'\n' C. Toronto'\n'", "AB");
                questions.Add(q2);

                TrueFalse q3 = new TrueFalse("True or False'\n'USA has 56 countries.", "True");
                questions.Add(q3);


                return questions;
            }

            string Grade(string answer, string correctAnswer)
            {
                if (answer.Length == correctAnswer.Length && answer.ToLower().Contains(correctAnswer.ToLower()))
                {
                    return "Correct!";
                }
                else
                {
                    return "Wrong!";
                }

            }


            void RunQuiz()
            {
                Console.WriteLine("Welcome to Quiz Time! Read the questions carefully. '\n'" +
                    "Good Luck!'\n'");

                foreach (Questions q in questions)
                {
                    Console.WriteLine(q.Question);
                    q.Answer = Console.ReadLine();
                    Grade(q.Answer, q.CorrectAnswer);
                }
            }

        }
    }
}
