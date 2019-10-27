using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void OnClick();　//抽象メソッドの定義
        static void Main(string[] args)
        {
           


           
            //StrDecorate(str, (string s) => { Console.WriteLine($"@{s}@"); });　//ラムダ式
            StrDecorate(str, s => Console.WriteLine("再生しました")); //更に簡略されたラムダ式
            StrDecorate(str, s => Console.WriteLine("削除しました"));
        }
        static void Star(OnClick,onclick)
        {
            onclick();
        }
      
    }
}

