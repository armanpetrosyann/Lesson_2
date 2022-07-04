using System;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = 10.55555d;
            float numberTwo = 20.555555f;

            decimal result = (decimal)((double)numberOne + numberTwo);

            Console.WriteLine($"Result of {numberOne} + {numberTwo} is: {result}");


            // if..else

            Console.WriteLine("Enter two number to check which is bigger");

            Console.Write("Enter first number: ");

            int askForFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");

            int askForSecondNumber = Convert.ToInt32(Console.ReadLine());

            if (askForFirstNumber > askForSecondNumber)
            {
                Console.WriteLine($"{askForFirstNumber} is big than {askForSecondNumber}");
            }
            else if (askForSecondNumber < askForFirstNumber)
            {
                Console.WriteLine($"{askForSecondNumber} is big than {askForFirstNumber}");
            }
            else if (askForFirstNumber == askForSecondNumber)
            {
                Console.WriteLine($"{askForFirstNumber} is equals to {askForSecondNumber}");
            }
            else
            {
                Console.WriteLine("Something gone wrong!");
            }


        }
    }
}
