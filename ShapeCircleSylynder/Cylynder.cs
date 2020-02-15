using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCircleSylynder
{
    class Cylynder : Circle
    {
        public double Height { get; set; }
        public Cylynder()
        {
            this.Height = 1.0;
        }
        public Cylynder(double height)
        {
            this.Height = height;
        }
        public Cylynder(double height, double radius) : base(radius)
        {
            this.Height = height;
            this.Radius = radius;
        }
        public Cylynder(double height,double radius,string color,bool filled) : base(radius,color,filled)
        {
            this.Height = height;
            this.Radius = radius;
        }
        public override double GetArea()
        {
            return 2 * Math.PI * Radius*(Height + Radius);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Cylynder Height = " + Height);
            Console.WriteLine("Cylynder Area = " + GetArea());
            Console.WriteLine("Cylynder Perimeter = " + GetPerimeter());
        }
    }
}
