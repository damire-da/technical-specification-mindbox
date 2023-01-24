namespace CalculationArea2DFigure
{
    public class Triangle : Figure
    {
        private int a;
        private int b;
        private int c;


        /// <summary>
        /// Конструктор для стандартного треугольника.
        /// </summary>
        /// <param name="a">Одна из сторон труегольника.</param>
        /// <param name="b">Одна из сторон труегольника.</param>
        /// <param name="c">Одна из сторон труегольника.</param>
        /// <exception cref="Exception"></exception>
        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Сторона треугольника не может быть 0 или меньше нуля!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception($"Треугольника с такими сторонами не существует: {a}, {b}, {c}.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
            
        }

        /// <summary>
        /// Нахождения площади треугольника по трем сторонам.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double GetSquare()
        {
            double halfMeter = GetHalfMeter();

            return Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));
        }


        /// <summary>
        /// Проверка треугольника, является ли он прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return true;
            }

            return false;
        }



        /// <summary>
        /// Нахождение периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double GetHalfMeter()
        {
            return (double)(a + b + c) / 2;
        }
    }
}
