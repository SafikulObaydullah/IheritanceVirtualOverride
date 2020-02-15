using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCircleSylynder
{
    class Square : Rectangle
    {
        public Square(double side)
        {
            this.Width = side;
            this.Length = side;
        }
        public Square(double side, string color, bool filled) : base(side,side,color,filled)
        {
            this.Width = side;
            this.Length = side;
        }
        public virtual double GetArea()
        {
            return Width * Length;
        }
        public virtual double GetPerimeter()
        {
            return 2 * (Width * Length);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Square Area = " + GetArea());
            Console.WriteLine("Square Perimeter = " + GetPerimeter());
        }
    }
}
