using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
        static void Main()
        {
            var quizQs = AddingQuestions();
            Quiz quiz = new Quiz();
            foreach(Question qs in quizQs)
            {
                quiz.AddQuestion(qs);
            }

            quiz.RunQuiz();

        }

            List<Question> questions = new List<Question>();
             public static List<Question> AddingQuestions()
            {
                List<Question> questions = new List<Question>();

                MultipleChoice q1 = new MultipleChoice("How many angles does a rectangle have?\n A. Only 1 \n B. It has 2\n C. It has 3", "C");
                questions.Add(q1);

                Checkbox q2 = new Checkbox("Multiple Choice'\n Which city/ies is in South America?\n A. Brazil\n B. Rio\n C. Toronto\n", "AB");
                questions.Add(q2);

                TrueFalse q3 = new TrueFalse("True or False\nUSA has 56 countries.", "True");
                questions.Add(q3);


                return questions;
            }

            

        }
    }
