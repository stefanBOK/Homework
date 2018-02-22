using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mgmhibitches
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {5,24,7,5 },
                { 3,1,35,6},
                {1,6,234,67 },
                {123,31,13,87 }
            };
            int n = (int)Math.Sqrt(a.Length);
            for (int i =0; i<n; i++)
            {
                for (int j=i;j<n;j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
        }
            Console.ReadLine();

    }
}
