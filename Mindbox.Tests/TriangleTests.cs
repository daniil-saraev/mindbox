using Mindbox.Core;

namespace Mindbox.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(5, 4, 3, 6)]
    [InlineData(5.5, 4.5, 3.5, 7.85)]
    public void Triangle_CalculateArea_ReturnsCorrectArea(
        double firstSide,
        double secondSide,
        double thirdSide,
        double expectedAreaRounded)
    {
        Triangle triangle = new(firstSide, secondSide, thirdSide);

        double actualArea = Math.Round(triangle.CalculateArea(), 2);

        Assert.Equal(expectedAreaRounded, actualArea);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 2)]
    [InlineData(1, 0, 2)]
    [InlineData(1, 2, 0)]
    [InlineData(-1, -2, -3)]
    [InlineData(-1, 1, 2)]
    [InlineData(1, -2, 2)]
    [InlineData(1, 2, -3)]
    public void Triangle_InvalidSides_ThrowsArgumentException(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Theory]
    [InlineData(8, 17, 15, true)]
    [InlineData(2, 3, 2, false)]
    public void Triangle_IsRightAngled_ReturnsCorrectResult(
        double firstSide,
        double secondSide,
        double thirdSide,
        bool expectedResult)

    {
        Triangle triangle = new(firstSide, secondSide, thirdSide);

        bool actualResult = triangle.IsRightAngled();

        Assert.Equal(expectedResult, actualResult);
    }
}