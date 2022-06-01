using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите: 1 - для вывода пассажирских самолётов, 2 - для вывода военных самолётов" +
                    "3 - для вывода транспортных самолётов, 4 - для выхода.");
                var a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Plane plane2 = GetPlane(Spetiality.Passenger, "Airbus A310", 940, 12100);
                    string p = plane2.AirPlane(plane2);
                    string p1 = plane2.Information();
                    Console.WriteLine(p);
                    Console.WriteLine(p1);
                }
                else if (a == 2)
                {
                    Plane plane = GetPlane(Spetiality.War, "Boeing F/A-18E/F Super Hornet", 1915, 29937);
                    string w = plane.AirPlane(plane);
                    string w1 = plane.Information();
                    Console.WriteLine(w);
                    Console.WriteLine(w1);

                }
                else if (a == 3)
                {
                    Plane plane3 = GetPlane(Spetiality.Cargo, "ИЛ-76", 850, 13716);
                    string c = plane3.AirPlane(plane3);
                    string c1 = plane3.Information();
                    Console.WriteLine(c);
                    Console.WriteLine(c1);

                }

                else if (a < 1 || a > 4)
                {
                    Console.WriteLine("Введите корректный символ");
                }
                else if (a == 4)
                {
                    break;
                }
            }
        }

        private static Plane GetPlane(Spetiality spetialityType, string name, int speed, int height)
        {
            switch (spetialityType)
            {
                case Spetiality.War:
                    return new War(name, speed, height);

                case Spetiality.Passenger:
                    return new Passenger(name, speed, height);
                case Spetiality.Cargo:
                    return new Cargo(name, speed, height);

                default: throw new Exception("Неизвестная классификация самолёта");

            }
        }
        public enum Spetiality
        {
            War = 1,
            Passenger = 2,
            Cargo = 3,

        }
       
    }
}

