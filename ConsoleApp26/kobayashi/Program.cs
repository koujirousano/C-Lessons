using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = GetInt();
            if (m % 2 == 0)
            {
                Console.WriteLine("{0}はTrue", m);
            }
            else
            {
                Console.WriteLine("{0}はFalse", m);
            }
        }

        private static int GetInt()
        {
            

                Console.Write("整数を入力してください: ");

            int n=int.Parse(Console.ReadLine());
            return n;
        }
    }
}