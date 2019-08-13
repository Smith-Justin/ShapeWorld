namespace ShapeWorld.Domain.Interfaces
{
    public interface IThreeD
    {
        double Height { get; set; }
        double Volume();
    }
}