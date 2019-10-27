using System;
using System.Collections.Generic;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<Figure>{
            //new Square("四角形",5.0,4.0),
            //new Triangle("三角形",4.0,3.0)
            //};
            Figure[] figure = new Figure[2];
            figure[0] = new Square("四角形", 5.0, 4.0);

            figure[1] = new Triangle("三角形", 4.0, 3.0);

            for (int i = 0; i < figure.Length; i++)
            {
                Figure v=figure[i];
                Console.WriteLine($"横:{v.Width:F1},縦:{v.Height:F1},図形:{v.Name}の面積は{v.GetArea():F1}");

                //list.ForEach((v) => {
                //Console.WriteLine($"横:{v.Width:F1},縦:{v.Height:F1},図形:{v.Name}の面積は{v.GetArea():F1}");

                //});
            }
        }
        abstract class Figure
        {
            public string Name { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public Figure() { }
            public Figure(string name, double width, double height)
            {
                this.Name = name;
                this.Width = width;
                this.Height = height;
            }

            public abstract double GetArea();
        }

        class Square : Figure
        {
            public Square(string name, double width, double height) : base(name, width, height) { } //baseは自分のフィールドにつめる
            public override double GetArea()
            {
                return this.Width * this.Height;
            }
        }
        class Triangle : Figure
        {
            public Triangle(string name, double width, double height) : base(name, width, height) { }
            public override double GetArea()
            {
                return this.Width * this.Height / 2;
            }
        }
    }
}

