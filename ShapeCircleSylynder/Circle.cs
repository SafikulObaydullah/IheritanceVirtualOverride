using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCircleSylynder
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 2.5;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle(double radius,string color,bool filled) : base ( color, filled)
        {
            //Color = "red"; can not assign
            //filled = true;
            this.Radius = radius;
        }
        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void Display()
        {
            Console.WriteLine("Area = " + GetArea());
            Console.WriteLine("Perimeter = " + GetPerimeter());
        }
    }
}
