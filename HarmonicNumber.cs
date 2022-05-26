using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void Harmonic()
        {
            double HP = 0.0;
            Console.WriteLine("Enter the Number :");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("1/{0}+", i);
                HP += 1 / (float)i;
            }
            Console.Write("\n");
            Console.WriteLine("Harmonic Number :" + HP);
        }
    }
}
