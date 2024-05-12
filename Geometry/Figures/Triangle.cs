using Geometry.Interfaces;
namespace Geometry.Figures;
public class Triangle : IFigure
{
    public Triangle()
    {
        SideOne = SideTwo = SideThree = 1.0;
    }

    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;

        Validate();
    }

    public double SideOne { get; }
    public double SideTwo { get; }
    public double SideThree { get; }

    public double Area
    {
        get
        {
            var hp = (SideOne + SideTwo + SideThree) / 2;
            return Math.Sqrt(hp) * (hp - SideOne) * (hp - SideTwo) * (hp - SideThree);
        }
    }

    private void Validate()
    {
        // проверка стороны положительные
        if (SideOne <= 0 || SideTwo <= 0 || SideThree <= 0)
            throw new ArgumentException($"One or more sides are not positive");
        // проверка является ли фигура - треугольником
        else if (SideOne + SideTwo < SideThree || SideOne + SideThree < SideTwo || SideTwo + SideThree < SideOne)
            throw new ArgumentException($"Figure is not type Triangle");
    }
}