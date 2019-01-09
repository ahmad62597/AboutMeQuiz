using System;

namespace AboutMeQuiz
{
    class Program 
    {
        static void Main(string[] args)
        {   //welcome message
            Console.WriteLine("Welcome to my About Me Quiz! How well do you know me?");
            

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
            int score = 0;

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

            //Asks the questions from the array, and returns an answer

            string QuestionAndAnswer(string question)
            {
                //asks the question
                Console.WriteLine($"--> {question}");

                //get the answer
                string answer = Console.ReadLine().ToLower();

                Console.WriteLine();

                return answer;
            }

            //compares given answer against answers within the array
            //returns true if it is correct, otherwise will return false

            bool CheckAnswer(string answer, string userInput)
            {
                //checks for answers for an int
                if (answer == userInput) return true;

                //checks for answers with string
                else if (string.Compare(answer, userInput) == 0) return true;

                //check for true and false answer
                else if (answer[0] == userInput[0] && (userInput[0] == 't' || userInput[0] == 'f')) return true;

                return false;


            }

            void ShowResults(bool correct, string answer)

            {
                if (correct)

                {
                    Console.WriteLine("Nice, youre right!");
                }

                else
                {
                    Console.WriteLine("Nope, thats wrong");
                }
            }

            //score function, adds and updates

            int UpdateScore(bool correctAnswer)
            {
                if (correctAnswer)
                {
                    return 1;
                }
                else return 0;
                  
            }
            
        }

  

      
    }
}
