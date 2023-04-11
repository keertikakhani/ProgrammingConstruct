using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElse 
    {  
        // 1. checking two integers are equal or not using if-else statement
        public static void Compare()
        {
              Console.WriteLine("enter an integer");
              int num1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter an integer");
              int num2 = Convert.ToInt32(Console.ReadLine());

              if (num1 == num2)
              {
                 Console.WriteLine("Both integers are equal");
              }
              else
              {
                  Console.WriteLine("Both integers are not equal");
              }
        }

        // 2. checking a number is even or odd using if-else statement

        public static void Check()
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even number", number);
            }
            else
            {
                Console.WriteLine("{0} is odd number", number);
            }
        }

        // 3. checking whether a candidate is elgibile for vote or not using if-else statement

        public static void CheckElgibilty()
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("you are elgible for vote");
            }
            else
            {
                Console.WriteLine("You are not elgible for vote");
            }
        }

    }
}
        
    

