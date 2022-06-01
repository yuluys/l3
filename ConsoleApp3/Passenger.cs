using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Passenger : Plane
    {
        private string Сlassification = "Пассажирский";
        private int Tonnage = 280;
        public Passenger(string name, int speed, int height)
            : base(name, speed, height) { }

        public override string Information()
        {
            return base.Information() + $"Классификация: {Сlassification}\nВместимость: {Tonnage} человек\n";
        }

        public override string AirPlane(Plane plane)
        {
            return $"Модель самолёта: {Name}, летает со скоростью: {Speed} км/ч, на высоте: {Height} метров\n";
        }
    }
}
