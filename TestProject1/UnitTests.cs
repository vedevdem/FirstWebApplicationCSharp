using WebApplication1;

namespace TestProject1;

[TestClass]
public class UnitTests
{
    [TestMethod]
    [DataRow(4, 3, 5, "345")]
    [DataRow(5, 5, 6, "556")]
    [DataRow(15, 13, 4, "41315")]
    public void TriangleConstructorTest(double firstSide, double secondSide, double thirdSide, string expectedResult)
    {
        //Arrange
        //Act
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var result = triangle.GetMinSide().ToString() + triangle.GetMidSide().ToString() + triangle.GetMaxSide().ToString();
        //Assert
        Assert.AreEqual(expectedResult, result, "msg");
    }

    [TestMethod]
    [DataRow(4, 3, 5, true)]
    [DataRow(5, 5, 6, false)]
    [DataRow(15, 13, 4, false)]
    [DataRow(15, 12, 9, true)]
    public void TriangleIsRectangularTests(double firstSide, double secondSide, double thirdSide, bool expectedResult)
    {
        //Arrange
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        //Act
        var result = triangle.IsRectangular();
        //Assert
        Assert.AreEqual(expectedResult, result, "msg");
    }
    [TestMethod]
    [DataRow(3, 4, 5, 6)]
    [DataRow(5, 5, 6, 12)]
    [DataRow(15, 13, 4, 24)]
    public void TriangleAreaTest(double firstSide, double secondSide, double thirdSide, double expectedResult)
    {
        //Arrange
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        //Act
        var result = triangle.GetArea();
        //Assert
        Assert.AreEqual(expectedResult, result, "Some message");
    }

    [TestMethod]
    [DataRow(1, Math.PI)]
    [DataRow(2, 4 * Math.PI)]
    [DataRow(3, 9 * Math.PI)]
    public void CircleAreaTest(double radius, double expectedResult)
    {
        //Arrange
        var circle = new Circle(radius);
        //Act
        var result = circle.GetArea();
        //Assert
        Assert.AreEqual(expectedResult, result, "Msg");
    }

    [TestMethod]
    [DataRow(3, 4, 5, 6)]
    [DataRow(5, 5, 6, 12)]
    [DataRow(15, 13, 4, 24)]
    public void ProcessorTestForSingleTriangle(double firstSide, double secondSide, double thirdSide, double expectedResult)
    {
        //Arrange
        var processor = new Processor();
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var triangleList = new List<IFigure>
            {
                triangle
            };
        //Act
        var result = processor.SumArea(triangleList);
        //Assert
        Assert.AreEqual(expectedResult, result, "msg");
    }

    [TestMethod]
    [DataRow(1, Math.PI)]
    [DataRow(2, 4 * Math.PI)]
    [DataRow(3, 9 * Math.PI)]
    public void ProcessorTestForSingleCircle(double radius, double expectedResult)
    {
        //Arrange
        var processor = new Processor();
        var circle = new Circle(radius);
        var circleList = new List<IFigure>
            {
                circle
            };
        //Act
        var result = processor.SumArea(circleList);
        //Assert
        Assert.AreEqual(expectedResult, result, "msg");
    }

    [TestMethod]
    public void ProcessorTestForTriangles()
    {
        //Arrange
        var processor = new Processor();
        var triangle1 = new Triangle(3, 4, 5);
        var triangle2 = new Triangle(5, 5, 6);
        var triangle3 = new Triangle(15, 13, 4);
        var triangleList = new List<IFigure>
            {
                triangle1,
                triangle2,
                triangle3
            };
        //Act
        var result = processor.SumArea(triangleList);
        //Assert
        Assert.AreEqual(42, result, "msg");
    }

    [TestMethod]
    public void ProcessorTestForCircles()
    {
        //Arrange
        var processor = new Processor();
        var circle1 = new Circle(1);
        var circle2 = new Circle(2);
        var circle3 = new Circle(3);
        var circleList = new List<IFigure>
            {
                circle1,
                circle2,
                circle3
            };
        //Act
        var result = processor.SumArea(circleList);
        //Assert
        Assert.AreEqual(14 * Math.PI, result, "msg");
    }

    [TestMethod]
    public void ProcessorTestForMixedFigures()
    {
        //Arrange
        var processor = new Processor();
        var triangle1 = new Triangle(3, 4, 5);
        var triangle2 = new Triangle(5, 5, 6);
        var triangle3 = new Triangle(15, 13, 4);
        var circle1 = new Circle(1);
        var circle2 = new Circle(2);
        var circle3 = new Circle(3);
        var figureList = new List<IFigure>
            {
                triangle1,
                triangle2,
                triangle3,
                circle1,
                circle2,
                circle3
            };
        //Act
        var result = processor.SumArea(figureList);
        //Assert
        Assert.AreEqual(14 * Math.PI + 42.0, result, 0.0000000000001, "msg");
    }
}