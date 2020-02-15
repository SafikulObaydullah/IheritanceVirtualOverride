using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCircleSylynder
{
    public class Shape
    {
        private string Color { get; set; }
        private bool filled { get; set; }
        public Shape()
        {
            Color = "Red";
            filled = true;
        }
        public Shape(string color,bool filled)
        {
            Color = color;
            filled = filled;
        }
        public virtual void  Display()
        {
            Console.WriteLine("Color = " + Color);
            Console.WriteLine("Fillled = " + true);
        }
    }
}
