using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //引数の戻り値とintが一致しているから

        static void Main(string[] args)
        {
            Console.Write("目標体重>");
            var weightGoal = int.Parse(Console.ReadLine());
            Console.Write("現在の体重>");
            var weightNow = int.Parse(Console.ReadLine());

            /*var strArr = Console.ReadLine().Split(',');
            var data = new int[strArr.Length];
            for(int i = 0; i < strArr.Length; i++)
            {
                data[i] = int.Parse(strArr[i]);
            }*/
            //↓は上と同じ意味


            Console.WriteLine("");
        }
        static void Weights(int weightGoal, int weightNow)　//最小値最大値を求めるには便利なメソッド
        { 
            if (weightGoal >= weightNow)
            {
                Result = ((weightGoal- weightNow) + "kg痩せましょう!");
            }
            if(weightGoal <= weightNow)
            {
                Result = ((weightNow - weightGoal) + "kg太りましょう!");
            }
            else
            {

            }
        }
        
    }
}