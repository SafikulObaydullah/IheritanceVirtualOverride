using System;

namespace ShapeCircleSylynder
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape obj1 = new Circle(2);
            obj1.Display();
            Console.WriteLine("=================");
            Shape obj3 = new Cylynder(2, 3);
            obj3.Display();
            Console.WriteLine("=================");
            Shape obj4 = new Rectangle();
            obj4.Display();
            Console.WriteLine("=================");
            Square obj5 = new Square(2.5,"Green",false);
            obj5.Display();
            Console.WriteLine("=================");


        }
    }
}
