using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(100, 200, 300, 400, "赤");
            Circle c2 = new Circle(250, 50, 350, 150, "青");
            Rectangle r1 = new Rectangle(300, 0, 400, 150, "緑");
            Line l1 = new Line(10, 20, 120, 0, "黒", 5);

            List<Figure> figures = new List<Figure>();
            figures.Add(c1);
            figures.Add(c2);
            figures.Add(r1);
            figures.Add(l1);
            foreach(Figure f in figures)
            {
                f.Draw();
            }
        }
    }
}
