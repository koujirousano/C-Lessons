using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    class Player
    {
        public string name; // プレイヤの名前
        public int hp;      // プレイヤの体力

        // Playerクラスのコンストラクタ
        public Player()
        {
            this.name = "たかし";
            this.hp = 100;
        }

        // 攻撃メソッド
        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        // 防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }

    }
}
