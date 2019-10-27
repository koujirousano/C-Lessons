using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        delegate int MathFunc(int a, int b); //引数の戻り値とintが一致しているから
        static void Main(string[] args)
        {
            MathFunc mf = Plus;
            Console.WriteLine(mf(5, 2));
            Console.WriteLine(Calc(10, 2, Plus));
            Console.WriteLine(Calc(10, 2, delegate (int a, int b) { return a * b; }));
            Console.WriteLine(Calc(10,2,(a,b)=>a/b));
            Console.WriteLine(Calc(10, 2, (a, b) => a > b ? a : b)); //三行演算子

        }
        static int Plus(int a, int b)
        {
            return a + b;

        }
        /*static int Calc(int a, int b, MathFunc mf)
        {
            return mf(a, b);
        }*/
        static int Calc(int a,int b, Func<int, int, int> mf) //Func<int,int,戻り値>
        {
            return mf(a, b);
        }
    }
}
