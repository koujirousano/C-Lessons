using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyGame {
    class Program {
        static void Main(string[] args) {
            Console.Write("おさるの名前を決めてください:>");
            string name = Console.ReadLine();
            Console.Write("おさるの歳を決めてください:>");
            int age = int.Parse(Console.ReadLine());
            Monkey m = new Monkey(name, age);
            while (true) {
                Console.Write("おさるに何をさせますか？1…挨拶、2…竹馬、3…逆立ち、4…終了>");
                int input = int.Parse(Console.ReadLine());
                switch (input) {
                    case 1:
                        m.Aisatsu();
                        break;
                    case 2:
                        m.Takeuma();
                        break;
                    case 3:
                        m.Sakadachi();
                        break;
                    default:
                        Console.WriteLine("アプリケーションを終了します");
                        return;
                    
                }
            }
        }
    }
}
