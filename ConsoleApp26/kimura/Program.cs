using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static int Kimura()
        {
            Console.Write("今年は？");
            int a = int.Parse(Console.ReadLine());
            Console.Write("生まれた年は?");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                b++;
                }
                return a;
            }
        }

        static void Main(string[] args)
        {

            Kimura();


        }
}
