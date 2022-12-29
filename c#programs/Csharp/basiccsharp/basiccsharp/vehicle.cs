using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class vehicle
    {
        public String name;
        public String model;
        public String make;
        public float price;
        public string color;
        public int speed;

        public void start()
        {
            Console.WriteLine("Vehicle has started");
            //speed = 0;
            this.speed = 0;
        }

        public void move()
        {
            Console.WriteLine("Vehicle has moved");
            //speed = 0;
            this.speed = this.speed + 5;
        }

        public void stop()
        {
            Console.WriteLine("Vehicle has stopped");
            //speed = 0;
            this.speed = 0;
        }

        public string info()
        {
            Console.WriteLine("info");
            return $" Name : {this.name} \nModel : {this.model} \nmake: {this.make} \nprice:{this.price} \nSpeed: {this.speed}";

        }

    }

    internal class Car :vehicle
    {
        public string ac;

        public void move()
        {
            Console.WriteLine("Car has moved");
            //speed = 0;
            this.speed = this.speed + 10;
        }

    }
}
