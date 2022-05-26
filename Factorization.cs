using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factorization
    {
        public static void Factor()
        {
            int N, x;
            Console.WriteLine("Enter the Number ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= N; x++)
            {
                if (N % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
