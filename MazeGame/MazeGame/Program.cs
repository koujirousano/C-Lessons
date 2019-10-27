using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        static char[] map = {
            '#','#','#','#','#',
            '#',' ',' ',' ','#',
            '#',' ','#',' ','#',
            '#','P','#','G','#',
            '#','#','#','#','#',
        };

        static void DrawMap()
        {
            for (int i = 0; i < map.Length; i++)
            {
                Console.Write(map[i]);
                if ((i + 1) % 5 == 0)
                {
                    Console.Write(System.Environment.NewLine);
                }
            }
        }

        static void MovePlayer(string key)
        {
            int playerPos = Array.IndexOf(map, 'P');
            int playerNextPos = 0;
            if (key == "a")
            {
                playerNextPos = playerPos - 1;
            }
            else if (key == "d")
            {
                playerNextPos = playerPos + 1;
            }
            else if (key == "w")
            {
                playerNextPos = playerPos - 5;
            }
            else if (key == "s")
            {
                playerNextPos = playerPos + 5;
            }
            else
            {
                return;
            }

            if (map[playerNextPos] != '#')
            {
                map[playerNextPos] = 'P';
                map[playerPos] = ' ';
            }
        }

        // ゴール判定のメソッド
        static bool CheckGoal()
        {
            // map中に'G'の文字がない場合はtrue、
            // 'G'の文字がある場合にはfalseを返す
            if (Array.IndexOf(map, 'G') < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // 初期状態のマップを表示
            DrawMap();

            while (true)
            {
                string key = Console.ReadLine();

                MovePlayer(key);

                // ゴールしたらwhile文を抜けてゲームクリア
                if (CheckGoal())
                {
                    break;
                }

                DrawMap();
            }
            Console.WriteLine("ゲームクリア！");
        }
    }
}