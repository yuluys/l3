using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class War : Plane
    {
        private string Сlassification = "Военный";
        private string Arm = "20 миллиметровой пушкой и оснащен 11 точками подвески";
        public War(string name, int speed, int height)
            : base(name, speed, height) { }

        public override string Information()
        {

            return base.Information() + $"Классификация: {Сlassification}\nВооружение: {Arm}\n";

        }
        public override string AirPlane(Plane plane)
        {
            return $"Модель самолёта: {Name}, летает со скоростью: {Speed} км/ч, на высоте: {Height} метров\n";
        }
    }
}


