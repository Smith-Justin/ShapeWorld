namespace ShapeWorld.Domain.Models
{
    public abstract class Shape{
        //backing fields

        //properties
        public int NumberOfEdges{ get; }

        //methods
        public virtual double Perimeter()
        {
            return 0;
        }

        public abstract double SurfaceArea();

        public double Volume()
        {
            return 0;
        }

        //controller
        public Shape(int edges)
        {
            NumberOfEdges=edges;
        }
    }
}