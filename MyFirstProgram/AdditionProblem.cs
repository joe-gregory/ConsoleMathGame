using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class AdditionProblem
    {
        public string ProblemText { get; private set; } = string.Empty;
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }
        public int Answer { get; private set; }
        public int Difficulty { get; private set; }

        public AdditionProblem(int difficulty = 1)
        {
            Difficulty = difficulty;

            Random random = new Random();

            switch (Difficulty)
            {
                case 1:
                    Number1 = random.Next(1, 10);
                    Number2 = random.Next(1, 10);
                    break;
                case 2:
                    Number1 = random.Next(10, 100);
                    Number2 = random.Next(10, 100);
                    break;
                case 3:
                    Number1 = random.Next(100, 1000);
                    Number2 = random.Next(100, 1000);
                    break;
                case 4:
                    Number1 = random.Next(1000, 10000);
                    Number2 = random.Next(1000, 10000);
                    break;
                default:
                    break;
            }
            Answer = Number1 + Number2;
            ProblemText = $"What is the result of adding {Number1} + {Number2}";
        }

        public bool CheckAnswer(int answer)
        {
            if (answer == Answer) return true;
            else return false;
        }

    }
}
