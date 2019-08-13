using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
    public class GenericShape<S> where S : Shape
    {
        public void SayHello(S shape)
        {
            System.Console.WriteLine(shape+" Generic");
        }

        public void SayHello(Shape shape)
        {
            System.Console.WriteLine(shape);
        }
    }
}