using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class SwitchStatement
    {
        // 1. Take User input and print week day name using switch case statement

        public static void WeekDayName()
        {
            Console.WriteLine("enter any number in the range 1 to 7 to print weekday name");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter the number in range");
                    break;
            }
        }

        // 2. taking two numbers from user and performing arithmatic operations like addition, subtraction, multiplication and division using switch case

        public static void ArithmaticOperations()
        {
            Console.WriteLine("which arithmatic opertion do you want to perform");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double num2 = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double num3 = num1 + num2;
                    Console.WriteLine(num3);
                    break;
                case 2:
                    double num4 = num1 - num2;
                    Console.WriteLine(num4);
                    break;

                case 3:
                   double num5 = num1 * num2;
                    Console.WriteLine(num5);
                    break;
                case 4:
                    double num6 = num1 / num2;
                    Console.WriteLine(num6);
                    break;
            }
        }
    }
}


   

