using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 420, 120, 600, 0, 1200 };
            var newHP = hp.Where(n => n >= 500);
            foreach(int h in newHP){
                Console.WriteLine(hp);
            }

        }
    }
}
