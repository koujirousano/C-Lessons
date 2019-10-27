using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[5];
            enemies[0] = new UFO();
            enemies[1] = new Star();
            enemies[2] = new Star();
            enemies[3] = new Meteor();
            enemies[4] = new Meteor();
            for(int i = 0; i < enemies.Length; i++) { //forreach(Enemy e in enemies){}
                enemies[i].Move();
            }
        }
    
    }
}
