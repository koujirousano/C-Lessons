using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static int HappyBirthday()
        {
            Console.Write("今年は？");
            int a = int.Parse(Console.ReadLine());

            Console.Write("生まれた年は?");
            int b = int.Parse(Console.ReadLine());

            var sum = a - b;

            Console.WriteLine("あなたは" + sum + "歳です");


            return sum;
        }

        static void Main(string[] args)
        {

            HappyBirthday();


        }
    }
}
