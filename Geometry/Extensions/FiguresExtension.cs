using Geometry.Interfaces;
namespace Geometry.Extensions
{
    public static class FiguresExtension
    {
        public static double GetAreaFor<T>(this T source) where T : class, IFigure => source.Area;

        public static bool CheckFigureFor<T>(this T source, Predicate<T> conditionInvoke) where T : class, IFigure => conditionInvoke.Invoke(source);
    }
}