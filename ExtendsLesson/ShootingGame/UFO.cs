﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame {
    class UFO :Enemy{
        public override void Move() {
            Console.WriteLine("ジグザグに移動");
        }
    }
}
