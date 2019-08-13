using System;
using ShapeWorld.Domain.Models;
using ShapeWorld.Domain.Collections;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape();
            PlayWithCollection();
            PlayWithGeneric();
        }

        private static void PlayWithShape()
        {
            Shape someShape = new Rectangle();
            Square someSquare = new Square();
            Rectangle someRectangle = new Rectangle() as Square; // if the "as" casting (Square) doesn't work, it will return the "new" type (Rectangle)
            //Rectangle someRectangle2 = (Shape) new Rectangle(); // this form of casting doesn't work because Shape is abstract
        }

        private static void PlayWithCollection()
        {
            ShapeArray sa = new ShapeArray();
            sa.DimensionalArray();
            sa.MyList();
            sa.MyDictionary();
        }

        private static void PlayWithGeneric()
        {
            var gs = new GenericShape<Triangle>();

            //gs.SayHello("shape");
            gs.SayHello(new Triangle());

            var gs2 = new GenericShape<Shape>();

            gs2.SayHello(new Triangle());

            var gs3 = new GenericShape<Rectangle>();

            gs3.SayHello(new Square());
            gs3.SayHello(new Triangle());
        }
    }
}
