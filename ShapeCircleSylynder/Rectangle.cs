using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCircleSylynder
{
    class Rectangle : Shape
    {
        public double Width { get;set; }
        public double Length { get;set; }
        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangle(double width,double length)
        {
            this.Width = width;
            this.Length = length;
        }
        public Rectangle(double width,double lenght ,string color,bool filled) : base(color,filled) 
        {
            this.Width = width;
            this.Length = lenght;
        }
        public virtual double GetArea()
        {
            return Width * Length;
        }
        public virtual double GetPerimeter()
        {
            return 2 * (Width + Length);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Rectangel width = " + Width);
            Console.WriteLine("Rectangel Length = " + Length);
            Console.WriteLine("Rectangle Area = " + GetArea());
            Console.WriteLine("Rectangle GetPerimeter = " + GetPerimeter());
        }
    }
}
