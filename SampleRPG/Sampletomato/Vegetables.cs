using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletomato
{
    class Vegetables
    {
     
        public String color;
        public int price;

        public Vegetables(string color, int price)
        {
            this.color = color;
            this.price = price;
        }

        public void Info()
        {
            Console.WriteLine(this.color);
            Console.WriteLine(this.price);
        }
    }

}
