using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static int Weights()
        {
            Console.WriteLine("今の体重は？");
            int weightNow = int.Parse(Console.ReadLine());

            Console.Write("目標体重は？");
            int weightGoal = int.Parse(Console.ReadLine());



            if (weightNow <= 40 && weightGoal <= 30)
            {
                Console.WriteLine("あまり頑張る必要なし！");

            }
            else if (weightNow <= 70 && weightGoal <= 30)
            {
                Console.WriteLine("少し頑張る必要あり！");

            }
            else
            {
                Console.WriteLine("かなり頑張った方がいいかも！");

            }


            return weightGoal;
        }

        static void Main(string[] args)
        {

            Weights();


        }
    }
}