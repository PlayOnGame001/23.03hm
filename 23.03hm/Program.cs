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
        public string nazvanie { get; set; }
        public string vid_transpotra { get; set; }
        public string skorost { get; set; }
        public Transport() { }
        public Transport(string name, string type, string speed)
        {
            this.nazvanie = nazvanie;
            this.vid_transpotra = vid_transpotra;
            this.skorost = skorost;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {nazvanie}");
            Console.WriteLine($"Type: {vid_transpotra}");
            Console.WriteLine($"Speed: {skorost}");
        }
        public IClone Clone()
        {
            Transport trans = new Transport();
            trans.nazvanie = nazvanie;
            trans.vid_transpotra = vid_transpotra;
            trans.skorost = skorost;
            return trans;
        }
    }
    class Corabl : Transport, IClone { }
    class Mashina : Transport, IClone { }
    class Samolet : Transport, IClone { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Corabl ship = new Corabl();
            ship.nazvanie = "Круизный";
            ship.vid_transpotra = "Турестический";
            ship.skorost = "Высокая";
            ship.Clone();
            Mashina car = new Mashina();
            car.nazvanie = "ferari";
            car.vid_transpotra = "спортивная";
            car.skorost = "Очень Высокая";
            car.Clone();
            Samolet plane = new Samolet();
            ship.nazvanie = "Истребитель";
            ship.vid_transpotra = "Военная";
            ship.skorost = "Очень Высокая";
            ship.Clone();
        }
    }
}