using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            floydTriangle(5);

            Console.ReadLine();
        }

        private static void floydTriangle(int v)
        {
            int k = 1;

            for (int i = 1; i <= v; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(k + "\t");
                    k++;
                }

                Console.WriteLine();
            }
        }
    }
}
