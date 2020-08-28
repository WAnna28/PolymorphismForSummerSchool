using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismForSummerSchool
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 2020;
        }

        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Square : Drawing
    {
        public double Length { get; set; }

        public Square()
        {
            Length = 2021;
        }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Height = 18.18;
            Width = 19.19;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
