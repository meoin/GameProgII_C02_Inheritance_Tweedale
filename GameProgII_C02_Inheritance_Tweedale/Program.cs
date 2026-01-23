using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_C02_Inheritance_Tweedale
{
    internal class Program
    {
        private static int _score = 0;
        private static List<Question> _quizQuestions = new List<Question> 
        {
            new Question(question: "Who is the FIRST final boss in The Binding of Isaac?", answer: "Mom"),
            new MultipleChoiceQuestion(question: "Which of these is NOT a real item?", 
                options: new string[] { "Guppy's Paw", "Guppy's Eye", "Guppy's Heart", "Guppy's Hairball" }, answer: 3),
            new TrueOrFalseQuestion(question : "True or False: Isaac and his mother lived alone in a small house on a hill.", answerAsBool: true),
            new Question(question : "What was the most recent PAID DLC for The Binding of Isaac: Rebirth called?", answer: "Repentance"),
            new MultipleChoiceQuestion(question: "What item does Isaac start with after you unlock it?", 
                options: new string[] { "Birthright", "The D6", "Isaac's Tears", "The Poop" }, answer: 2),
            new TrueOrFalseQuestion(question: "True or False: Eraser is an item added in the Afterbirth DLC.", answerAsBool: false),
            new Question(question: "Which playable non-tainted character CANNOT shoot tears of their own?", answer: "Lilith"),
            new MultipleChoiceQuestion(question: "Which of these floors is part of the \"alt path\" that leads to fighting Mother?", 
                options: new string[] { "Mines", "Necropolis", "Flooded Caves", "Cellar" }, answer: 1),
            new TrueOrFalseQuestion(question: "True or False: The maximum coin hearts that The Keeper can get is 3.", answerAsBool: false)
        };

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Michael's Binding of Isaac quiz!");
            Console.WriteLine("Press any key to start: ");
            Console.ReadKey(true);

            foreach (Question question in _quizQuestions)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;

                question.Ask();

                Console.WriteLine();

                bool result = question.CheckAnswer();

                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("The correct answer was: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(question.GetAnswer());
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;

            Console.Write("You answered ");

            double percentage = (double)_score / _quizQuestions.Count;
            if (percentage > 0.8) Console.ForegroundColor = ConsoleColor.Green;
            else if (percentage >= 0.4) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(_score);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" questions correctly!");

            Console.WriteLine();
            Console.WriteLine("Okay thanks for playing bye :)");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
