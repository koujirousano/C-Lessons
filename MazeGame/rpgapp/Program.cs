using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgapp
{
    class Program
    {
        static char[] map = {
            '#','#','#','#','#','#','#','#','#','#',
            '#','#','#','#','#','#','#','#','#','#',
            '#','#','#','#','#','#','#','#','#','#'
        };
        
        static void DrawMap()
        {
            for (int i = 0; i < map.Length; i++)
            {
                Console.Write(map[i]);
                if ((i + 1) % 50 == 0)
                {
                    Console.Write(System.Environment.NewLine);
                }
            }
        }
        static void Rans()
        {
            int seed = Environment.TickCount;
            Random rnd = new System.Random(); // インスタンスを生成

            for (int i = 1; i <= 10; i++)
            {
                int r = rnd.Next(100);        // 0～9の乱数を取得
                Console.Write(r);

            }//for(i)文の終わり
        }
        static void Attack()
        {

        }
        static void Main(string[] args)
        {
            Rans();
            Attack();
            DrawMap();
            

        }

    }
}
