namespace ShapeWorld.Domain.Models
{
    public class Triangle : Shape
    {
        public override double SurfaceArea()
        {
            return 0;
        }

        public Triangle() : base(3) {}
    }
}