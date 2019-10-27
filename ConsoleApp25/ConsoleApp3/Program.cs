using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 550, 420, 600, 800, 220 };
            var newHp = hp.Select(n => n - 100);
            foreach (int n in newHp)
            {
                Console.WriteLine(n);
            }
        }
    }
}
