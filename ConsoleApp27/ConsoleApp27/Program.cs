using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenCards
{
    class Program
    {
        const int CARDS = 10;//１デッキのカード枚数
        const int MAX_TURN = 3;//ターン数
        const int MAX_HP = 2500;//敵の初期HP
        const int MIN_POWER = 20;//攻撃力の最小値
        const int MAX_POWER = 100;//攻撃力の最大値
        static int enemyHp;//敵のHP
        static bool isEnemyDie;//敵が死んだか?
        static int[] cards = new int[CARDS];//10枚のカード配列
        static Random rand = new Random();//ランダムインスタンス

        //10枚のカードをランダムに生成し配列につめる
        static void CreateDeck()
        {
            for (int i = 0; i < CARDS; i++)
            {
                cards[i] = rand.Next(MIN_POWER, MAX_POWER + 1);
            }
        }
        //ゲームの初期化処理
        static void InitGame()
        {
            enemyHp = MAX_HP;
            isEnemyDie = false;
            CreateDeck();
            Console.WriteLine("\nガチャを引いた");
            Console.WriteLine(string.Join(" ", cards));
            Console.WriteLine("BasePower:" + cards.Sum());
            WaitEnter();
        }
        //入力待ち処理
        static void WaitEnter()
        {
            Console.ReadLine();
            Console.WriteLine();
        }
        //敵のHP表示
        static void DisplayHP()
        {
            Console.WriteLine("HP:" + enemyHp);
            int count = enemyHp / 100;
            if (enemyHp % 100 != 0)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //敵の出現処理
        static void AppearEnemy()
        {
            Console.WriteLine("敵が現れた!");
            DisplayHP();
            WaitEnter();
        }
        //1ターンの処理(引数はターン数)
        static void Turn(int n)
        {
            Console.WriteLine("turn" + (n + 1));
            //LINQをつかって30%の確率で2倍の処理簡潔に表現
            var damages = cards.Select(OneCardPower).ToArray();
            //配列から文字列生成
            Console.WriteLine(string.Join(" ", damages));
            int sum = damages.Sum();
            Console.WriteLine($"合計{sum}ダメージを与えた！");
            enemyHp -= sum;
            if (enemyHp <= 0)
            {
                isEnemyDie = true;
            }
            if (isEnemyDie)
            {
                Console.WriteLine("タワバァ！");
            }
            else
            {
                DisplayHP();
            }
            WaitEnter();
        }
        //30%でpower2倍の処理メソッド
        static int OneCardPower(int cardPower)
        {
            int n = rand.Next(10);//０～９の10個数値をランダムに生成
            return n < 3 ? cardPower * 2 : cardPower;//0,1,2のときに2倍
        }
        //もう一度するかの処理(return trueでもう一度)
        static bool IsRetry()
        {
            Console.Write("もう一度?(Yes...1,No...2)>");
            int input = int.Parse(Console.ReadLine());
            return input == 1;
        }
        //メインメソッド
        static void Main(string[] args)
        {
            while (true)
            {
                InitGame();
                AppearEnemy();
                /*メインルーチン*/
                for (int i = 0; i < MAX_TURN && !isEnemyDie; i++)
                {
                    Turn(i);
                }
                /*ゲーム結果*/
                if (isEnemyDie)
                {
                    Console.WriteLine("討伐成功!");
                }
                else
                {
                    Console.WriteLine("討伐に失敗した。。。");
                }
                if (!IsRetry())
                {
                    Console.WriteLine("アプリケーションを終了します");
                    break;
                }
            }
        }
    }
}
