using Lesson_3.CalculatorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public class UserInterface
    {
        public void UserInterafaceMethod()
        {
            Calculator calculator = new Calculator();
            for (; ; )
            {
                Console.WriteLine("Select an action");
                Console.WriteLine();
                Console.WriteLine("1 - Multiply");
                Console.WriteLine("2 - Division");
                Console.WriteLine("3 - Summ");
                Console.WriteLine("4 - Subscription");
                Console.WriteLine("5 - Print the last result");
                Console.WriteLine("6 - Print last five results");
                Console.WriteLine("7 - Repeat last action");
                Console.WriteLine("8 - Enter expression");
                Console.WriteLine("0 - Exit");

                string choise = Console.ReadLine();
                int select = 10;

                if (choise.All(char.IsDigit))
                {
                    select = int.Parse(choise);
                }
                else
                {
                    Console.WriteLine("!!!Wrong entered numbers!!!");
                }


                float[] numbers = new float[2];

                switch (select)
                {
                    case 1:
                        calculator.Action = Actions.Mul;
                        numbers = EnterNumbers();
                        if (CheackArray(numbers))
                        {
                            break;
                        }
                        calculator.Multiply(numbers[0], numbers[1]);
                        break;
                    case 2:
                        calculator.Action = Actions.Mul;
                        numbers = EnterNumbers();
                        if (CheackArray(numbers))
                        {
                            break;
                        }
                        calculator.Division(numbers[0], numbers[1]);
                        break;
                    case 3:
                        calculator.Action = Actions.Mul;
                        numbers = EnterNumbers();
                        if (CheackArray(numbers))
                        {
                            break;
                        }
                        calculator.Summ(numbers[0], numbers[1]);
                        break;
                    case 4:
                        calculator.Action = Actions.Mul;
                        numbers = EnterNumbers();
                        if (CheackArray(numbers))
                        {
                            break;
                        }
                        calculator.Subtraction(numbers[0], numbers[1]);
                        break;
                    case 5:
                        Console.WriteLine($"Last Result is = {calculator.LastResult}");
                        break;
                    case 6:
                        if (calculator.Iterations == 6)
                        {
                            Console.WriteLine("!! No results !!");
                            break;
                        }

                        for (int i = 0; i < calculator.Iterations; i++)
                        {
                            Console.WriteLine($"result {i+1}) = {calculator.Results[i]}");
                        }
                        break;
                    case 7:
                        numbers = EnterNumbers();
                        if (CheackArray(numbers))
                        {
                            break;
                        }
                        calculator.RepeatLastAction(numbers[0], numbers[1]);
                        break;
                    case 8:
                        numbers = EnterNumbers();
                        char action = EnterAction();
                        if (CheackArray(numbers) || CheckAction(action))
                        {
                            break;
                        }
                        calculator.EnterExpression(numbers[0], numbers[1], action);
                        break;
                    case 0:
                        Console.WriteLine("Good Buy");
                        return;
                    default:
                        break;
                }

            }
        }

        private float[] EnterNumbers()
        {
            Console.Write("Enter first number - ");
            string number1 = Console.ReadLine();
            Console.Write("Enter second number - ");
            string number2 = Console.ReadLine();

            if (!number1.All(char.IsDigit)
               || !number2.All(char.IsDigit))
            {
                Console.WriteLine("number 1 or number 2 is not numbers");
                return null;
            }
            else if (string.IsNullOrEmpty(number1)
                || string.IsNullOrEmpty(number2))
            {
                Console.WriteLine("Number1 or Number2 Null or empty");
                return null;
            }

            float[] results = { float.Parse(number1), float.Parse(number2) };
            return results;
        }

        private bool CheackArray(float[] array)
        {
            bool result = false;
            if (array is null)
            {
                result = true;
            };

            return result;
        }

        private char EnterAction()
        {
            Console.Write("Enter action - ");
            char action = char.Parse(Console.ReadLine());

            if (action != '+' && action != '-'
               && action != '*' && action != '/')
            {
                Console.WriteLine("!!Wrong action!!!");
                Console.WriteLine("Correct action \"+,-,/,*\"");
                return action;
            }

            return action;
        }

        private bool CheckAction(char action)
        {
            bool result = false;
            if (action != '+' && action != '-'
               && action != '*' && action != '/')
            {
                result = true;
            }

            return result;
        }
    }
}

