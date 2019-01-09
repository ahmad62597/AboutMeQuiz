using System;

namespace AboutMeQuiz
{
    class Program 
    {
        static void Main(string[] args)
        {   //welcome message
            Console.WriteLine("Welcome to my About Me Quiz! How well do you know me?");
            Console.ReadKey();

            //array for my questions
            string[] questions =
            {
                "Where was I born?",
                "What is my favorite animal?",
                "How old am I?",
                "What is my favorite book?",
                "True or False: :I know 4 different languages"

            };

            //array for my answers in order of the questions
            string[] answers =
                
             {
           
                "Karachi",
                "Tiger",
                "22",
                "Lord of the Rings",
                "True"
                };

            //stretch goal for correct answer counter
            int totalscore = 0;

            //Begin the quiz
            for (int i = 0; i < questions.Length; i++)
            //Ask the questions and check it with the answers
            {
                string answer = QuestionAndAnswer(questions[i]);
                bool correct = CheckAnswer(answers[i], answer);

                //show the right answer
                ShowResults(correct, answers[i]);
                score += UpdateScore(correct);
            }



        }

      
    }
}
