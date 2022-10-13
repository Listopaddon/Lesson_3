using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3.CalculatorFolder
{
    public class Operations
    {
        public float Summ(float number1, float number2)
        {
            CheckNumbersIsNotString(number1, number2);
            return number1 + number2;
        }

        public float Subtraction(float number1, float number2)
        {
            CheckNumbersIsNotString(number1, number2);
            return number1 - number2;
        }

        public float Multiply(float number1, float number2)
        {
            CheckNumbersIsNotString(number1, number2);
            CheckOnZero(number1, number2);
            return number1 * number2;
        }

        public float Division(float number1, float number2)
        {
            CheckNumbersIsNotString(number1, number2);
            CheckOnZero(number1, number2);
            return number1 / number2;
        }

        private void CheckOnZero (float number1,float number2)
        {
            if(number1 == 0 || number2 == 0)
            {
                Console.WriteLine("!!! Number 1 or number 2 is zero !!!");
            };
        }

        private void CheckNumbersIsNotString(float number1,float number2)
        {
            if(!float.TryParse(number1.ToString(), out float number1Check) 
               || !float.TryParse(number2.ToString(), out float number2Check))
            {
                Console.WriteLine("number 1 or number 2 is not numbers");
            }
        }
    }
}
