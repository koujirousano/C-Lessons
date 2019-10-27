using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Test(ref int val)
        {
            val = 10;
        }
        
        
        static void Main(string[] args)
        {

            int a = 3;
            Test(ref a);
            Console.WriteLine(a);
            
        }
    }
}
