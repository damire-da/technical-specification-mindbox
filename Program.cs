using CalculationArea2DFigure;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(2, 5, 5);

            Console.WriteLine(triangle.IsRectangular());
            
            Console.WriteLine(triangle.GetSquare());

            Console.WriteLine(triangle.GetHalfMeter());
        }
    }
}