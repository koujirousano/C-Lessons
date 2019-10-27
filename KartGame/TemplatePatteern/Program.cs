using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyCharacter
            {
                Name = "ロト"
            };
            mc.Introduce();
        }
        abstract class Character
        {
            public string Name { get; set; }
            public void Introduce()
            {
                Console.WriteLine($"はじめまして{Name}です。");
                DoIntroduce();
                Console.WriteLine("よろしくおねがいします");
            }
            public abstract void DoIntroduce();

        }
        class MyCharacter : Character
        {
            public override void DoIntroduce()
            {
                Console.WriteLine("特技は走ることです。");
            }
        }
    }
}


