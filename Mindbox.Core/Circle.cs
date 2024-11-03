using System;

namespace Mindbox.Core
{
    public class Circle : IHasArea
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero");
            }

            this.radius = radius;
        }

        /// <inheritdoc />
        public double CalculateArea() =>
            Math.Pow(radius, 2) * Math.PI;
    }
}