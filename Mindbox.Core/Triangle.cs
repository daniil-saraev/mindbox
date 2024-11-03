using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.Core
{
    public class Triangle : IHasArea
    {
        private readonly double firstSide;
        private readonly double secondSide;
        private readonly double thirdSide;

        public Triangle(double thirdSide, double secondSide, double firstSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException("Each side must be greater than zero", nameof(firstSide));
            }

            if (secondSide <= 0)
            {
                throw new ArgumentException("Each side must be greater than zero", nameof(secondSide));
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentException("Each side must be greater than zero", nameof(thirdSide));
            }


            this.thirdSide = thirdSide;
            this.secondSide = secondSide;
            this.firstSide = firstSide;
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(
                p * (p - firstSide) * (p - secondSide) * (p - thirdSide)
            );
            return area;
        }

        /// <summary>
        /// Вычислить, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник является прямоугольным, иначе - false.</returns>
        public bool IsRightAngled()
        {
            IEnumerable<double> sides = new[] { firstSide, secondSide, thirdSide }
                .OrderByDescending(x => x);
            double hypotenuseSquare = Math.Pow(sides.First(), 2);
            return sides
                .Skip(1)
                .Sum(x => Math.Pow(x, 2)) == hypotenuseSquare;
        }
    }
}