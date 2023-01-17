using CalculationArea2DFigure;

namespace CalculationtArea2DFigureTests
{
    [TestClass]
    public class CalculationtArea2DFigureTests
    {
        /// <summary>
        /// Тестирование метода GetSquare у класс Triangle.
        /// </summary>
        [TestMethod]
        public void GetSquareTriangleWithSides_3_4_5_6returned()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6;
            
            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирование метода GetHalfMeter у класс Triangle.
        /// </summary>
        [TestMethod]
        public void GetHalfMeterTriangle_3_4_5_12returned()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetHalfMeter();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Тестирование метода GetSquare у класс Circle.
        /// </summary>
        [TestMethod]
        public void GetSquareCircle_radius5_()
        {
            // arrange
            int radius = 5;
            double expected = 78.53981633974483;

            // act
            Circle circle = new Circle(radius);
            double actual = circle.GetSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}