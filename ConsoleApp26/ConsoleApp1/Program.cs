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
            Console.WriteLine("整数をカンマ区切りで入力してください>");
            
            var a = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
           
            Console.WriteLine("整数をカンマ区切りで入力してください>");

            var b = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            GetMinMax(a, out int minVal, out int maxVal);
            GetMinMaxTwo(b, out int minbVal, out int maxbVal);
            Console.WriteLine($"最小値{minVal},最大値{maxVal}");
        }
        static void GetMinMax(int[] arr, out int min, out int max)　//最小値最大値を求めるには便利なメソッド
        {
            min = arr[0];
            max = arr[0];
            foreach (var n in arr)
            {
                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;


                }
            }
        }
            static void GetMinMaxTwo(int[] arr, out int minb, out int maxb) //最小値最大値を求めるには便利なメソッド
            {
                minb = arr[0];
                maxb = arr[0];
                foreach (var n in arr)
                {
                    if (n < minb)
                    {
                        minb = n;
                    }
                    if (n > maxb)
                    {
                        maxb = n;


                    }
                }
            }
    }
}

