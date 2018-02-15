using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ta
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = 5.25745243896m;
            decimal number2 = 9.8544531763m;
            number1 += number2;
            Console.WriteLine(number1.ToString("#.######"));
        }
    }
}
