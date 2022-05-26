using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2
    {
        public static void CalculatePowerOf2()
        {
            Console.WriteLine("Enter the value to calculate power");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 31)
            {
                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Number not in rang between 0 to 31");
            }
        }
    }
}
