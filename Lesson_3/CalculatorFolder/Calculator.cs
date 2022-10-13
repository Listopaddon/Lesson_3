using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3.CalculatorFolder
{
    public class Calculator
    {
        float[] results = new float[5];
        int iterations = 6;
        float lastResult = 0;
        Operations operations = new Operations();
        Actions action = Actions.Sub;

        public int Iterations
        {
            get { return iterations; }
        }

        public float[] Results
        {
            get
            {
                return results;
            }
        }

        public Actions Action
        {
            set { action = value; }
        }

        public float LastResult
        {
            get
            {
                return lastResult;
            }
        }

        public void Summ(float number1, float number2)
        {
            CheckIterations();
            results[iterations] = operations.Summ(number1, number2);
            lastResult = results[iterations];
            iterations++;
        }

        public void Subtraction(float number1, float number2)
        {
            CheckIterations();
            results[iterations] = operations.Subtraction(number1, number2);
            lastResult = results[iterations];
            iterations++;
        }

        public void Division(float number1, float number2)
        {
            CheckIterations();
            results[iterations] = operations.Division(number1, number2);
            lastResult = results[iterations];
            iterations++;
        }

        public void Multiply(float number1, float number2)
        {
            CheckIterations();
            results[iterations] = operations.Multiply(number1, number2);
            lastResult = results[iterations];
            iterations++;
        }

        public void RepeatLastAction(float number1, float number2)
        {
            if (action == Actions.Div)
            {
                Division(number1, number2);
            }
            else if (action == Actions.Mul)
            {
                Multiply(number1, number2);
            }
            else if (action == Actions.Sub)
            {
                Subtraction(number1, number2);
            }
            else if (action == Actions.Summ)
            {
                Summ(number1, number2);
            }
            else
            {
                Console.WriteLine("Wrong Action!!!");
            }
        }

        public void EnterExpression(float number1,float number2, char action)
        {
            if (action == (char)Actions.Div)
            {
                Division(number1, number2);
            }
            else if (action == (char)Actions.Mul)
            {
                Multiply(number1, number2);
            }
            else if (action == (char)Actions.Sub)
            {
                Subtraction(number1, number2);
            }
            else if (action == (char)Actions.Summ)
            {
                Summ(number1, number2);
            }
            else
            {
                Console.WriteLine("Wrong Action!!!");
            }
        }

        private void CheckIterations()
        {
            if (iterations > 5)
            {
                iterations = 0;
            }
        }
    }
}
