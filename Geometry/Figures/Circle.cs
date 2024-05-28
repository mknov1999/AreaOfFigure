using Geometry.Figures.Base;
namespace Geometry.Figures;

public class Circle : BaseFigure
{
    public double Radius { get; set; }
    public override double GetArea() => Math.Pow(Radius, 2) * Math.PI;
    public override double GetPerimeter() => 2 * Radius * Math.PI;
}