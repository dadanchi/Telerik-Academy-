namespace Abstraction.Contracts
{
    public interface IRectangle : IFigure
    {
        double Width { get; }

        double Height { get; }
    }
}
