using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ForLoop
    {
        // 1. take a user input and print a table of power of 2

        public static void PowerOfTwo()
        {
            int p = 1;

            Console.WriteLine("Enter a number to print a table of power of 2");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("2^0 = 1");
                }
                else
                {
                    p = p * 2;
                    Console.WriteLine("2^{0} = {1}", i, p);
                }
            }
        }

        // 2. take a number N from user and print sum of squares from 1 to N 

        public static void SumOfSquares()
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                sum = sum + i * i;
            }

            Console.WriteLine("sum of squares from 1 to {0} is {1}", N, sum);
        }

        // 3. Take a number from user and find factorial of that number

        public static void FindFactorial()
        {
            int factorial = 1;

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i= 1; i<=number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("factorial of {0} is {1}", number, factorial);
        }
    }
}




        