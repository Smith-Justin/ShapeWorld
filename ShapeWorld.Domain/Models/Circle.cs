namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
        public override double SurfaceArea()
        {
            return 0;
        }

        public Circle() : base(1) {}
    }
}