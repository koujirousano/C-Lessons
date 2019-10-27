using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {
    class Car {
        float fuel;
        float ratio;
        float maxFuel;
        public Car(float fuel,float ratio,float maxFuel) {
            this.fuel = fuel;
            this.ratio = ratio;
            this.maxFuel = maxFuel;
        }
        public float Fuel {
            private set {
                this.fuel = value;
            }
            get {
                return this.fuel;
            }
        }
        public float Ratio {
            get {
                return this.ratio;
            }
        }
        public float MaxFuel {
            get {
                return this.maxFuel;
            }
        }

        public void ShowInfo() {
            Console.WriteLine($"現在の燃料は{Fuel:F1}リットルです。");
        }
        public void Run(int dist) {
            if (dist / Ratio <= Fuel) {
                Console.WriteLine($"{dist}キロ走行します");
                Fuel -= dist / Ratio;
            } else {
                Console.WriteLine("そんなに走れません!");
            }
        }
        public void AddFuel(float fuel) {
            float added = fuel + Fuel> MaxFuel ? MaxFuel - Fuel : fuel;
            Fuel += added;
            Console.WriteLine($"{added:F1}リットル給油します。");
            this.ShowInfo();
        }

    }
}
