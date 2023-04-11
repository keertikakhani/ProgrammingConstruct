using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElseifElse
    {
        // 1. finding largest of three numbers using if-elseif-else statement

        public static void LargestNumber()
        {
            Console.WriteLine("enter an integer");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an integer");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an integer");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2 && number1 > number3)
            {
                Console.WriteLine("{0} is largest number", number1);
            }
            else if(number2> number1 && number2 > number3)
            {
                Console.WriteLine("{0} is largest number", number2);
            }
            else
            {
                Console.WriteLine("{0} is largest number", number3);
            }
        }

        // 2. find the elgibilty of candidate for a professional course using if-elseif-else statement
        
        public static void FindElgibilty()
        {
            int mathsMarks = 72;
            int physicsMarks = 65;
            int chemistryMarks = 51;
            int totalMarks = mathsMarks + physicsMarks + chemistryMarks;
            int mathPhysics = mathsMarks + physicsMarks;
            int mathChemistry = mathsMarks + chemistryMarks;

            if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("candidate is elgible for admission");
            }
            else if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && mathPhysics >= 140 || mathChemistry >= 140)
            {
                Console.WriteLine("candidate is elgible for admission");
            }
            else
            {
                Console.WriteLine("candidate is not elgible for admission");
            }
        }

    }
}
