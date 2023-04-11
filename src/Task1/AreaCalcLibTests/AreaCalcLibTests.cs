using NUnit.Framework;
using AreaCalcLib.Figures;
namespace AreaCalcTests;

[TestFixture]
public class Tests
{
    //circle tests
    [Test]
    public void Circle_CalculateArea_Returns_Area()
    {
        //arrange
        var circle = new Circle(1);
        var expected = 3.1415926535897931;
        //act
        var area = circle.CalcArea();
        //assert
        Assert.AreEqual(expected, area);
    }
    [Test]
    public void Circle_CreateWithNegativeRadius_Throws_ArgumentOutOfRangeException()
    {
        //assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    //triangle tests
    [Test]
    public void Triangle_CalculateArea_Returns_Area()
    {
        //arrange
        var triangle = new Triangle(3, 4, 5);
        var expected = 6.0;
        //act
        var area = triangle.CalcArea();
        //assert
        Assert.AreEqual(expected, area);
    }

    [Test]
    public void Triangle_IsRectangular_Returns_True()
    {
        //arrange
        var triangle = new Triangle(3, 4, 5);
        var expected = true;
        //act
        var rectanularity = triangle.IsTriangleRectangular();
        //assert
        Assert.AreEqual(expected, rectanularity);
    }
    [Test]
    [TestCase(-1,1,1)]
    [TestCase(-1,-1,-1)]
    [TestCase(1,-1,1)]
    [TestCase(1,1,-1)]
    public void NegativeTriangleExceptionTest(int a, int b, int c)
    {
        //asserts
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a,b,c));

    }
}