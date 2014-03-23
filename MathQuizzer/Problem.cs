using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuizzer
{
    class Problem
    {
        public int operand1,
                   operand2,
                   choice,
                   trueAnswer,
                   min,
                   max;

        public int[] possibleAnswers = { 0, 0, 0, 0 };
       
        public double  minMod,
                       maxMod;

        public char[] func = { '+', '-', 'x', '÷', '%' };
        public char operate;

        public Problem()
        {
            Random number = new Random();
            operand1 = number.Next(1, 10);
            operand2 = number.Next(1, 10);
            choice = number.Next(1, 5);

            switch (choice)
            {
                case 0:
                    operate = func[0];
                    trueAnswer = operand1 + operand2;
                    break;
                case 1:
                    operate = func[1];
                    trueAnswer = operand1 - operand2;
                    break;
                case 2:
                    operate = func[2];
                    trueAnswer = operand1 * operand2;
                    break;
                case 3:
                    operate = func[3];
                    if (operand2 == 0)
                    {
                        operand2++;
                    }
                    trueAnswer = operand1 / operand2;
                    break;
                case 4:
                    operate = func[4];
                    if (operand1 == 0)
                    {
                        operand1++;
                    }

                    if (operand2 == 0)
                    {
                        operand2++;
                    }

                    if (operand1 < operand2)
                    {
                        int temp = operand2;
                        operand2 = operand1;
                        operand1 = temp;
                    }
                    trueAnswer = operand1 % operand2;
                    break;
                default:
                    Console.WriteLine("operator number failed to properly generate.");                    
                    break;
            }

            choice = number.Next(1,4);
            minMod = trueAnswer - (trueAnswer * .5);
            maxMod = trueAnswer + (trueAnswer * .5);
            if( trueAnswer <= 40 )
            {
                min = 1;
                max = 50;
            }
            else
            {
                min = Convert.ToInt32(minMod);
                max = Convert.ToInt32(maxMod);
            }

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    possibleAnswers[i] = number.Next(min, max);
                    if (possibleAnswers[i] == trueAnswer)
                    {
                        possibleAnswers[i]++;
                    }
                }
                else
                {
                    do
                    {
                        possibleAnswers[i] = number.Next(min, max);
                    }
                    while (possibleAnswers[i] == possibleAnswers[i-1]);
                }
                if (trueAnswer < 0)
                {
                    possibleAnswers[i] *= -1;
                }
            }
            
            switch( choice )
            {
                case 1:
                    possibleAnswers[0] = trueAnswer;
                    break;
                case 2:
                    possibleAnswers[1] = trueAnswer;
                    break;
                case 3:
                    possibleAnswers[2] = trueAnswer;
                    break;
                case 4:
                    possibleAnswers[3] = trueAnswer;
                    break;
                default:
                    Console.WriteLine("trueAnswer number failed to properly generate.");                  
                    break;
            }            
        }
    }
}
