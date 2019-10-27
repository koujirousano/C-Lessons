using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 35;
            int num2 = num1;
            Console.WriteLine(num2);
            num1 = 0;
            Console.WriteLine(num2);
            // player1のインスタンスを作り、名前と体力を代入
            //Player player1 = new Player();
            //player1.name = "たかし";
            //player1.hp = 100;
            // コンストラクタに引数を渡してインスタンスを作る
            //Player player1 = new Player("たかし", 100); 上の3行を一行で

            // player1の体力をコンソールに表示
            //Console.WriteLine(player1.name + "の体力は" + player1.hp);


            // player2のインスタンスを作り、名前と体力を代入
            //Player player2 = new Player();
            //player2.name = "ひろし";
            //player2.hp = 200;
            //Player player2 = new Player("ひろし", 200); 上の３行と同義
            //Console.WriteLine(player2.name + "の体力は" + player2.hp);

            //player1.Attack();   // player1が攻撃する
            //player2.Defense();  // player2が防御する
            // Shopクラスのインスタンスを作成
            //Shop shop = new Shop();

            // Shopクラスのメンバメソッドを呼び出す
            //shop.Sell();
            //shop.Buy();
        }
    }
}

