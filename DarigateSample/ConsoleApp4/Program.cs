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
            /*var strArr = Console.ReadLine().Split(',');
            var data = new int[strArr.Length];
            for(int i = 0; i < strArr.Length; i++)
            {
                data[i] = int.Parse(strArr[i]);
            }*/
            //↓は上と同じ意味
            var data = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            GetMinMax(data, out int minVal, out int maxVal);
            Console.WriteLine($"最小値{minVal},最大値{maxVal}");
        }
        static void GetMinMax(int[] arr,out int min,out int max)　//最小値最大値を求めるには便利なメソッド
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
    }
}
