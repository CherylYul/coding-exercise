using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    internal class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        private int numberOfDoors = 2;

        public Car()
        {
            Name = "Chuck";
            Speed = 10;
        }

        public Car(string pn) => Name = pn;
        public Car(string pn, int cs, out bool inDanger)
        {
            Name = pn;
            Speed = cs;
            inDanger = cs > 100 ? true : false;
        }
        public void PrintState() => Console.WriteLine($"{Name} is going {Speed} MPH");
        public void SpeedUp(int delta) => Speed += delta;
    }

    internal class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car MyCar { get; set; } = new Car();

        public Garage() { }
        public Garage(Car car, int number)
        {
            MyCar = car;
            NumberOfCars = number;
        }
    }
}
