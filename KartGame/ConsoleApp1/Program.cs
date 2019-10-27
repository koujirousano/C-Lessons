﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay cd = new CharDisplay('T');
            cd.Display();
            AbstractDisplay sd = new StringDisplay("Design Pattern");
            sd.Display();

        }
    }
}
