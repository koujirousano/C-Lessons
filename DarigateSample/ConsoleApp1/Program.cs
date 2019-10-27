using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void Decorate(string s);　//抽象メソッドの宣言
        static void Main(string[] args)
        {
            string str = "Hello";
            StrDecorate(str, Star);
            StrDecorate(str, delegate (string s)


             {
                 Console.WriteLine($"@{s}@");
             });
            //StrDecorate(str, (string s) => { Console.WriteLine($"@{s}@"); });　//ラムダ式
            StrDecorate(str, s => Console.WriteLine($"[{s}]")); //更に簡略されたラムダ式
            StrDecorate(str, s => Console.WriteLine($"[{s}]"));
        }
            static void Star(string s)
            {
                Console.WriteLine($"@{s}@");
            }
        static void StrDecorate(String str,Decorate dec)
        {
            dec(str);
        }
        
    }
}
