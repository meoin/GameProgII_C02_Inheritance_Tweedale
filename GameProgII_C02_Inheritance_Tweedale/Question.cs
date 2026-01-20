using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_C02_Inheritance_Tweedale
{
    internal class Question
    {
        protected string _questionText;
        protected string _answerText;

        public Question(string question, string answer) 
        {
            _questionText = question;
            _answerText = answer;
        }

        public void Ask() 
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer() 
        {
            string input = Console.ReadLine();
            Console.WriteLine();

            input = input.ToLower();

            if (input.Trim() == _answerText.ToLower().Trim()) return true;
            else return false;
        }
    }
}
