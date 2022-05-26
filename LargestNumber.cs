using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public static void FindingLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of the three numbers");


            Console.WriteLine("Input first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is the greatest among three");
                }
                else if (num1 < num3)
                {
                    Console.WriteLine("The 3rd number is greatest among the three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is the greatest among the three");
            }
        }
    }
}
