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

            // Enter  two number to check which is bigger or equals

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


            // Enter a number from 5 to 10 (range)

            int minRangeFive = 5;
            int maxRangeTen = 10;

            Console.WriteLine("Enter a number from 5 to 10 (range)");

            int askForNumber = Convert.ToInt32(Console.ReadLine());

            if (askForNumber > 5 && askForNumber < 10)
            {
                Console.WriteLine($"{askForNumber} is big from {minRangeFive} and small from {maxRangeTen}");
            }
            else
            {
                Console.WriteLine($"{askForNumber} is out of rang (5 - 10)");
            }

            // Enter number 5 or 10 only

            int fixFive = 5;
            int fixTen = 10;

            Console.WriteLine("Enter only 5 or 10 numbers");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == fixFive || firstNumber == fixTen)
            {
                Console.WriteLine($"{firstNumber} is {fixFive} or {fixTen}");
            }

            // Client deposit amount checker in a bank

            Console.WriteLine("Enter number to check deposit amount client of bank");

            double depositAmount = Convert.ToDouble(Console.ReadLine());

            if (depositAmount < 100)
            {
                double resultOfDepositAmount = (depositAmount / 5) * 100;
                Console.WriteLine(resultOfDepositAmount);
            }
            else if (depositAmount > 100 && depositAmount < 200)
            {
                double resultOfDepositAmount = (depositAmount / 7) * 100;
                Console.WriteLine(resultOfDepositAmount);
            }
            else if (depositAmount > 200)
            {
                double resultOfDepositAmount = (depositAmount / 10) * 100;
                Console.WriteLine(resultOfDepositAmount);
            }
            else
            {
                Console.WriteLine("Something gone wrong!");
            }

            // Client deposit amount checker in a bank with (bonus)

            double bonusToUser = 15d;

            Console.WriteLine("Enter number to check deposit amount client of bank (+15 bonus)");

            double depositAmountOfUser = Convert.ToDouble(Console.ReadLine());

            if (depositAmountOfUser < 100)
            {
                double resultOfDepositAmountWithBonus = ((depositAmountOfUser / 5) + bonusToUser) * 100;
                Console.WriteLine(resultOfDepositAmountWithBonus);
            }
            else if (depositAmountOfUser > 100 && depositAmountOfUser < 200)
            {
                double resultOfDepositAmountWithBonus = ((depositAmountOfUser / 7) + bonusToUser) * 100;
                Console.WriteLine(resultOfDepositAmountWithBonus);
            }
            else if (depositAmountOfUser > 200)
            {
                double resulOfDepositAmountWithBonus = ((depositAmountOfUser / 10) + bonusToUser) * 100;
                Console.WriteLine(resulOfDepositAmountWithBonus);
            }
            else
            {
                Console.WriteLine("Something gone wrong!");
            }

            // Calculator with operation types (+,-,*,/)

            int addition = 1;
            int subtraction = 2;
            int multiplication = 3;
            int divide = 4;


            Console.WriteLine("Enter two number and operation type to calculate");

            Console.Write("Enter first number: ");
            double numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter two number: ");
            double numTwo = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter operation type by symbol");
            Console.WriteLine($"1: Addition ({addition})");
            Console.WriteLine($"2: Subtraction ({subtraction})");
            Console.WriteLine($"3: Multiplication ({multiplication})");
            Console.WriteLine($"3: Divide ({divide})");

            int operationType = Convert.ToInt32(Console.ReadLine());

            switch (operationType)
            {
                case 1:
                    Console.WriteLine("You chose operation addition");
                    Console.WriteLine($"Result is: {numOne + numTwo}");
                    break;
                case 2:
                    Console.WriteLine("You chose operation subtraction");
                    Console.WriteLine($"Result is: {numOne - numTwo}");
                    break;
                case 3:
                    Console.WriteLine("You chose operation multiplication");
                    Console.WriteLine($"Result is: {numOne * numTwo}");
                    break;
                case 4:
                    Console.WriteLine("You chose operation subtraction");
                    Console.WriteLine($"Result is: {numOne / numTwo}");
                    break;
                default:
                    Console.WriteLine("Operation is not found");
                    break;
            }
        }
    }
}
