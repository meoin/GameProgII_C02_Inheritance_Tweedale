using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_C02_Inheritance_Tweedale
{
    internal class MultipleChoiceQuestion : Question
    {
        private string[] _answerOptions;
        private int _correctAnswer;

        public MultipleChoiceQuestion(string question, string[] options, int answer) : base(question, options[answer-1])
        {
            _answerOptions = options;
            _correctAnswer = answer;
        }

        public override bool CheckAnswer() 
        {
            for (int i = 0; i < _answerOptions.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {_answerOptions[i]}");
            }

            Console.WriteLine();

            int answer;

            while (true) 
            {
                char input = Console.ReadKey(true).KeyChar;
                if (char.IsDigit(input))
                {
                    answer = int.Parse(input.ToString());
                    break;
                }
            }

            if (answer == _correctAnswer) return true;
            else return false;
        }
    }
}
