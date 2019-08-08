namespace ShapeWorld.Domain.Models
{
    public class Square : Rectangle
    {
        private double _edgeLength;

        public override double Length
        {
            get
            {
                return _edgeLength;
            }

            set
            {
                _edgeLength = value;
            }
        }

        public override double Width
        {
            get
            {
                return _edgeLength;
            }

            set
            {
                _edgeLength = value;
            }
        }
    }
}