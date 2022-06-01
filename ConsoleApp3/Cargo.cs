using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Cargo : Plane
    {
        private string Сlassification = "Грузовой";
        private int Tonnage = 60;
        public Cargo(string name, int speed, int height)
            : base(name, speed, height) { }

        public override string Information()
        {
            return base.Information() + $"Классификация: {Сlassification}\nГрузоподъёмность: {Tonnage} тонн\n";
        }


        public override string AirPlane(Plane plane)
        {
            return $"Модель самолёта: {Name}, летает со скоростью: {Speed} км/ч, на высоте: {Height} метров\n";
        }
    }
}
