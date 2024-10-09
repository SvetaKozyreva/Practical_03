using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    internal class TCircle
    {
        double radius;
        static double kut;

        public TCircle()
        {
            radius = 0;
        }
        public TCircle(double r)
        {
            radius = r;
        }
        public TCircle(TCircle circle)
        {
            radius = circle.radius;
        }
        public double Radius
        {
            get { return radius; }
        }
        public static void InputKut()
        {
            Console.WriteLine("Введіть кут сектора:");
            kut = Convert.ToDouble(Console.ReadLine());
        }

        public void Input()
        {
            Console.WriteLine("Введіть радіус кола:");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"\nРадіус кола: {radius}\n" +
                $"Довжина кола:{LengthCircle()}\n" +
                $"Площа круга:{Sq()}\n" +
                $"Площа сектора(при куті {kut}):{Sector(kut)}");
        }
        public double Sq()
        {
            return Math.Round(Math.PI * radius * radius, 3);
        }
        public double Sector(double kut)
        {
            return Math.Round((Math.PI * radius * radius * kut) / 360, 3);
        }
        public double LengthCircle()
        {
            return Math.Round(2 * Math.PI * radius, 3);
        }
        public void Porivn(TCircle other)
        {
            if (this.radius == other.radius)
            {
                 Console.WriteLine("Кола рівні");
            }
            else if (this.radius >= other.radius)
            {
                Console.WriteLine($"Коло з радіусом {this.radius} більше кола з радіусом {other.Radius}.");
            }
            else  Console.WriteLine($"Коло з радіусом {other.radius} більше кола з радіусом {this.Radius}.");
        }
        public static TCircle operator +(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.radius + c2.radius);
        }
        public static TCircle operator -(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.radius - c2.radius);
        }
        public static TCircle operator *(TCircle c, double value)
        {
            return new TCircle(c.radius * value);
        }
    }
}
