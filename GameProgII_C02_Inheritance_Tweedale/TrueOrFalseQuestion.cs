using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_C02_Inheritance_Tweedale
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string question, bool answerAsBool) : base(question, answerAsBool.ToString()) 
        {
        
        }
    }
}
