using Geometry.Interfaces;
namespace Geometry.Figures;
public class Circle : IFigure
{
    public Circle()
    {
        Radius = 1.0;
    }

    public Circle(double radius)
    {
        Radius = radius;

        Validate();
    }

    public double Radius { get; }
    public double Area => Math.PI * Math.Pow(Radius, 2);

    private void Validate()
    {
        // проверка на положительное значение радиуса
        if (Radius <= 0)
            throw new ArgumentException("Radius must be positive");
    }
}