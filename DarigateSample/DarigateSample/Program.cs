using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarigateSample
{
    class Program
    {
        delegate void Decorate(string s); //引数の型と戻り値を定義
        static void Main(string[] args)
        {
            String str = "Hello";
            Decorate dec = Star; //引数と戻り値が同じだったら代入できる
            dec = Atsign; //メソッドを代入
            dec += Star;
            dec -= Atsign;
            dec = Console.WriteLine;

            dec(str);
        }
        static void Star(string s)
        {
            Console.WriteLine($"*{s}*");
        }
        static void Atsign(string s)
        {
            Console.WriteLine($"@*{s}*@");
        }
    }
}
