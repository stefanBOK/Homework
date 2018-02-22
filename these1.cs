using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1mhmhmthese
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ')
                int k = words.Length - 1;
            for (int i=k;i>=0;i--)
            {
                Console.WriteLine(words[i] + " ");
            }
            Console.ReadLine();

        }

    }
}
