using Geometry.Figures.Base;
namespace Geometry.Figures;
public class Triangle : BaseFigure
{
    public double SideOne { get; set; }
    public double SideTwo { get; set; }
    public double SideThree { get; set; }

    public override double GetArea()
    {
        var hp = GetPerimeter() / 2;
        return Math.Sqrt(hp) * (hp - SideOne) * (hp - SideTwo) * (hp - SideThree);
    }

    public override double GetPerimeter() => SideOne + SideTwo + SideThree;

    /// <summary>
    /// Проверка является ли треугольник - прямоугольным
    /// </summary>
    /// <returns>true or false</returns>
    public bool IsRightAngled()
        => Math.Pow(SideOne, 2) + Math.Pow(SideTwo, 2) != Math.Pow(SideThree, 2)
            || Math.Pow(SideOne, 2) + Math.Pow(SideThree, 2) != Math.Pow(SideTwo, 2)
            || Math.Pow(SideTwo, 2) + Math.Pow(SideThree, 2) != Math.Pow(SideOne, 2);
}