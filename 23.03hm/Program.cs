using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03hm
{
    interface IClone
    {
        IClone Clone();
    }

    class Transport : IClone
    {
        public string name { get; set; }
        public string type { get; set; }
        public string skorost { get; set; }
        public Transport() { }
        public Transport(string name, string type, string speed)
        {
            this.name = name;
            this.type = type;
            this.skorost = speed;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Speed: {skorost}");
        }
        public IClone Clone()
        {
            Transport trans = new Transport();
            trans.name = name;
            trans.type = type;
            trans.skorost = skorost;
            return trans;
        }
    }
    class Ship : Transport, IClone { }
    class Auto : Transport, IClone { }
    class Plane : Transport, IClone { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ship.name = "Авианосец";
            ship.type = "Военный";
            ship.speed = "Средний";

            ship.Clone();

        }
    }
}