using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    class SkyKart
    {
        public int weight;
        public int speed;


        public void Force()
        {
            Console.WriteLine("加速or減速");
        }


        public void Flying()
        {
            Console.WriteLine("離陸!");
        }
    }
}