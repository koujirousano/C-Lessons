﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SkyKart skyKart = new SkyKart();
            TurboKart turboKart = new TurboKart();
            turboKart.Force();
            turboKart.Turbo();
            skyKart.Force();
            skyKart.Flying();

        }
    }
}
