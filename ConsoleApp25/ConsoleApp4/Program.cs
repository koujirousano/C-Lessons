using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 550, 0, 600, 800, 220 };
            int num = hp.Select(n => n - 500).Where(n => n > 0).Count();;
            //var newHp = hp.Select(n => n - 100);
           
            
            Console.WriteLine(num);
            
        }
    
    }
}
