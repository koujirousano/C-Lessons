using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int math = 81;
            int english = 66;
            

            float average=(float)math/english; //小数点がでるのでfをつける
            Console.WriteLine("平均は"+average+"点");
        }
    }
}
