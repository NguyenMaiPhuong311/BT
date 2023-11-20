using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    internal class B4
    {
        static void Main(string[] args)
        {
            // Shape Test
            Shape shape = new Shape();
            Console.WriteLine(shape);

            shape = new Shape("red", false);
            Console.WriteLine(shape);

            // Circle Test
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            // Square Test
            Square square = new Square();
            Console.WriteLine(square);
            square.Resize(0.5);
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);
        }
    }
        public interface Resizeable
        {
        public void Resize(double percent);
        
        }
        
       


}
