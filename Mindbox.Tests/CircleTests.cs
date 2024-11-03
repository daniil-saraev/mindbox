using Mindbox.Core;

namespace Mindbox.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(10, 314.16)]
    [InlineData(5.25, 86.59)]
    public void Circle_CalculateArea_ReturnsCorrectArea(double radius, double expectedAreaRounded)
    {
        Circle circle = new(radius);

        double actualArea = Math.Round(circle.CalculateArea(), 2);

        Assert.Equal(expectedAreaRounded, actualArea);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void CreateCircle_InvalidRadius_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}