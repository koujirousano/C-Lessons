using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShowInfo());
            Console.WriteLine(ShowInfo("山田"));
            Console.WriteLine(ShowInfo("山田", 22)); //オーバーロードもどちらも可能
            Console.WriteLine(ShowInfo(age:30));
            Console.WriteLine(ShowInfo(age: 40, name:"タナカ"));
            //Console.WriteLine(ShowInfo(CalcAdd(2,4,5,1));
            //Console.WriteLine(ShowInfo(CalcAdd(2,3,5));
            //Console.WriteLine(ShowInfo(CalcAdd());
            Console.WriteLine(ShowInfo(age: 40, name: "タナカ"));
            Console.WriteLine(ShowInfo(age: 40, name: "タナカ"));

            static string ShowInfo(string name = "ゴンベ", int age = 20)
            {
                return $"{name}({age})";
            }
            /*static int CalcAdd(prams int[] data){ //可変長引数
                int sum = 0;
                foreach(var n in data)
                {
                    sum += n;
                }
            return sum;

            }*/
        static int CalcAdd(int first,params int[] data)
        {
            int sum = first;
        }

        }
    }
}
