using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_C02_Inheritance_Tweedale
{
    internal class Program
    {
        public static int _score = 0;
        public static List<Question> _quizQuestions = new List<Question> 
        {
            new Question("QUESTION", "ANSWER"),
            new Question("QUESTION", "ANSWER"),
            new Question("QUESTION", "ANSWER"),
            new MultipleChoiceQuestion("QUESTION", new string[] { "111", "222", "333", "444" }, 2),
            new MultipleChoiceQuestion("QUESTION", new string[] { "111", "222", "333", "444" }, 2),
            new MultipleChoiceQuestion("QUESTION", new string[] { "111", "222", "333", "444" }, 2),
            new TrueOrFalseQuestion("QUESTION", true),
            new TrueOrFalseQuestion("QUESTION", true),
            new TrueOrFalseQuestion("QUESTION", true)
        };

        static void Main(string[] args)
        {

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
