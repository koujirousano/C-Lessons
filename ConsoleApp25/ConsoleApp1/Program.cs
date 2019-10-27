
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp25
    {
        class Program
        {

            static void ShowEvenOrOdd(int n)
            {
                if (n%2 == 0)  //変数をメソッドで
                {
                    Console.WriteLine( "偶数");
                }
                else
                {
                    Console.WriteLine("奇数");
                }

            }
            static void Main(string[] args)
            {
                ShowEvenOrOdd(3); //泥棒でも
            }
        
    }
}
