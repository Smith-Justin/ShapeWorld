using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
    public class Cube : Shape, IThreeD
    {
        public double Height{ get; set; }

        public override double SurfaceArea()
        {
            return 0;
        }

        public Cube() : base(12)
        {
        }
    }
}