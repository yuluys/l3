using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Plane
    {
        public string Name { get; private set; }
        public int Speed { get; private set; }
        public int Height { get; private set; }

        public Plane(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        public Plane(string name, int speed, int height) : this(name, speed)
        {
            if (height == 10000)
                Height = 10000;
            else
                Height = height;
        }

        public virtual string AirPlane(Plane plane)
        {
            return $"Модель самолёта {Name} летает на высоте {Height } метров\n";
        }
        public virtual string Information()
        {
            return $"Модель самолёта: {Name}\nСкорость: {Speed} км/ч\nВысота полёта: {Height} метров\n";
        }
    }
}
