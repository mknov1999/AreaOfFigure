using Geometry.Figures;
using Geometry.Figures.Base;
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
            var area = triangle.GetArea();

            // Результаты
            Assert.IsNotNull(triangle.SideOne);
            Assert.IsNotNull(triangle.SideTwo);
            Assert.IsNotNull(triangle.SideThree);
            Assert.IsNotNull(area);
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
            var triangle = new Triangle()
            {
                SideOne = sideOne,
                SideTwo = sideTwo,
                SideThree = sideThree
            };

            // Проверка является ли треугольник - прямоугольным
            var isRightAngled = triangle.IsRightAngled();

            // площадь
            var area = triangle.GetArea();

            // Результаты
            Assert.IsTrue(isRightAngled);
            Assert.AreEqual(sideOne, triangle.SideOne);
            Assert.AreEqual(sideTwo, triangle.SideTwo);
            Assert.AreEqual(sideThree, triangle.SideThree);
            Assert.AreEqual(result, area);
        }

        [TestMethod]
        public void Test_CalculationArea_Circle_WithoutValues()
        {
            // Круг
            var circle = new Circle();
            // площадь
            var area = circle.GetArea();

            // Результаты
            Assert.IsNotNull(circle.Radius);
            Assert.IsNotNull(area);
        }

        [TestMethod]
        public void Test_CalculationArea_Circle()
        {
            // Входные данные
            var radius = 1;

            // Ожидаемый результат вычисления площади
            var result = Math.PI * Math.Pow(radius, 2);

            // Круг
            var circle = new Circle { Radius = radius };
            var area = circle.GetArea();

            // Сравнение результатов
            Assert.AreEqual(radius, circle.Radius);
            Assert.AreEqual(result, area);
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
            BaseFigure figure = new Triangle()
            {
                SideOne = sideOne,
                SideTwo = sideTwo,
                SideThree = sideThree
            };
            var area = figure.GetArea();

            // Результаты
            Assert.AreEqual(result, area);
        }
    }
}