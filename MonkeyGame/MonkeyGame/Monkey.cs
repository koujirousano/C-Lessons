using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyGame {
    class Monkey {
        public string Name { private set; get; }
        public int Age {
            set; get; }
        public Monkey(string name,int age) {
            Name = name;
            Age = age;
        }
        public void Aisatsu() {
            Console.WriteLine($"こんにちは{Name}({Age}才)です。よろしく!");
        }
        public void Takeuma() {
            Console.WriteLine($"{Name}は上手に竹馬にのった！");
        }
        public void Sakadachi() {
            Console.WriteLine($"{Name}はひょいと逆立ちをした！");
        }
    }
}
