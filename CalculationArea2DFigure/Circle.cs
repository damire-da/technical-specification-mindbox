namespace CalculationArea2DFigure
{
    public class Circle : Figure
    {

        private double radius;

        public Circle(double radius)
        {
            if ( radius <= 0)
            {
                throw new Exception($"Радиус круга не может быть меньше или равен нуля! radius = {radius}");
            }
            this.radius = radius;
        }

        /// <summary>
        /// Нахождение площади круга по радиусу.
        /// </summary>
        /// <returns> Площадь круга. </returns>
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
