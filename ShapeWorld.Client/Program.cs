using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape();
        }

        private static void PlayWithShape()
        {
            Shape someShape = new Rectangle();
            Square someSquare = new Square();
            Rectangle someRectangle = new Rectangle() as Square; // if the "as" casting (Square) doesn't work, it will return the "new" type (Rectangle)
            Rectangle someRectangle2 = (Shape) new Rectangle(); // this form of casting doesn't work because Shape is abstract

            Console.WriteLine(someShape.Volume());
            Console.WriteLine(someSquare.Volume());
        }
    }
}
