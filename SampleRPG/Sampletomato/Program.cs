using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletomato
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables vegetables1 = new Vegetables("赤", 200);
           

            Vegetables vegetables2 = new Vegetables("緑", 120);
            
            vegetables1.Info();
            vegetables2.Info();

        }

    }

}
