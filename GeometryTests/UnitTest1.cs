using Geometry.Extensions;
using Geometry.Figures;
using NUnit.Framework.Internal;

namespace GeometryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CalculationArea_Triangle_WithoutValues()
        {
            // Треугольник
            var triangle = new Triangle();

            // Результаты
            Assert.IsNotNull(triangle.SideOne);
            Assert.IsNotNull(triangle.SideTwo);
            Assert.IsNotNull(triangle.SideThree);
            Assert.IsNotNull(triangle.Area);
        }

        [TestMethod]
        public void Test_CalculationArea_Triangle()
        {
            // Входные данные
            var sideOne = 3;
            var sideTwo = 4;
            var sideThree = 5;
            
            // Ожидаемый результат
            var p = (sideOne + sideTwo + sideThree) / 2;
            var result = Math.Sqrt(p) * (p - sideOne) * (p - sideTwo) * (p - sideThree);
            
            // Треугольник
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            // Проверка является ли треугольник - прямоугольным
            var isRightAngled = FiguresExtension.CheckFigureFor(triangle, x => Math.Pow(x.SideOne, 2) + Math.Pow(x.SideTwo, 2) != Math.Pow(x.SideThree, 2)
            || Math.Pow(x.SideOne, 2) + Math.Pow(x.SideThree, 2) != Math.Pow(x.SideTwo, 2)
            || Math.Pow(x.SideTwo, 2) + Math.Pow(x.SideThree, 2) != Math.Pow(x.SideOne, 2));

            // Результаты
            Assert.IsTrue(isRightAngled);
            Assert.AreEqual(sideOne, triangle.SideOne);
            Assert.AreEqual(sideTwo, triangle.SideTwo);
            Assert.AreEqual(sideThree, triangle.SideThree);
            Assert.AreEqual(result, triangle.Area);
        }

        [TestMethod]
        public void Test_CalculationArea_Circle_WithoutValues()
        {
            // Круг
            var circle = new Circle();

            // Результаты
            Assert.IsNotNull(circle.Radius);
            Assert.IsNotNull(circle.Area);
        }

        [TestMethod]
        public void Test_CalculationArea_Circle()
        {
            // Входные данные
            var radius = 1;

            // Ожидаемый результат вычисления площади
            var result = Math.PI * Math.Pow(radius, 2);

            // Круг
            var circle = new Circle(radius);
            
            // Сравнение результатов
            Assert.AreEqual(radius, circle.Radius);
            Assert.AreEqual(result, circle.Area);
        }

        [TestMethod]
        public void Test_CalculationArea_Figure()
        {
            // Входные данные
            var sideOne = 1;
            var sideTwo = 2;
            var sideThree = 3;

            // Ожидаемый результат вычисления площади
            var p = (sideOne + sideTwo + sideThree) / 2;
            var result = Math.Sqrt(p) * (p - sideOne) * (p - sideTwo) * (p - sideThree);

            // Вычисление площади фигуры(треугльник)
            var figureArea = FiguresExtension.GetAreaFor<Triangle>(new(sideOne, sideTwo, sideThree));

            // Результаты
            Assert.AreEqual(result, figureArea);
        }

        [TestMethod]
        public void Test_Figures_Validations()
        {
            // Тестирование методов вадидации для круга и треугольника
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 10, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 10));

            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 0, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 3, 0));

            Assert.ThrowsException<ArgumentException>(() => new Triangle(-3, -4, -5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-3, 4, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, -4, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 4, -5));

            Assert.ThrowsException<ArgumentException>(() => new Circle(-8));
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }
    }
}