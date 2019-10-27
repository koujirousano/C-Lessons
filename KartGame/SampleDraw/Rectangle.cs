using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDraw
{
    class Rectangle : Figure
    {
        string fillColor;

        public Rectangle(int sx, int sy, int ex, int ey, string color)
        {
            this.startPosX = sx;
            this.startPosY = sy;
            this.endPosX = ex;
            this.endPosY = ey;
            this.fillColor = color;
        }

        public override void Draw()
        {
            
            int width = Math.Abs(this.endPosX - this.startPosX);
            int height = Math.Abs(this.endPosY - this.startPosY);
            Console.WriteLine("左上の点(" + this.startPosX + "," +
                              this.startPosY + ")から、(" +
                              width + "," + height + ")の大きさの" +
                              this.fillColor + "色の長方形を描画する");
        }
    }
}
