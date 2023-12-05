using FiguresLibrary.Figures;

namespace FiguresLibrary.Tests;

public class Tests
{
    [Test]
    public void Triangle_GetArea()
    {
        var triangle = new Triangle(3, 4, 5);
        const double tolerance = 0;
        const double expectedArea = 6;
        var area = triangle.GetArea();
        Assert.That(area, Is.EqualTo(expectedArea).Within(tolerance));
    }
    
    [Test]
    public void Triangle_GetArea_Point()
    {
        var triangle = new Triangle(3.25, 4.4, 5.56);
        const double tolerance = 1e-5;
        const double expectedArea = 7.14570553;
        var area = triangle.GetArea();
        Assert.That(area, Is.EqualTo(expectedArea).Within(tolerance));
    }
    
    [Test]
    public void Triangle_IsRight()
    {
        var triangle = new Triangle(3, 4, 5);
        const double tolerance = 0;
        var isRight = triangle.IsRight(tolerance);
        Assert.That(isRight, Is.True);
    }
    
    [Test]
    public void Triangle_IsNotRight()
    {
        var triangle = new Triangle(4, 4, 5);
        const double tolerance = 0;
        var isRight = triangle.IsRight(tolerance);
        Assert.That(isRight, Is.False);
    }
    
    [Test]
    public void Triangle_IsRight_Point()
    {
        var triangle = new Triangle(2.5, 1, 2.69258240);
        const double tolerance = 1e-7;
        var isRight = triangle.IsRight(tolerance);
        Assert.That(isRight, Is.True);
    }
    
    [Test]
    public void Triangle_IsNotRight_Point()
    {
        var triangle = new Triangle(2.5, 2.12, 2.69258240);
        const double tolerance = 1e-7;
        var isRight = triangle.IsRight(tolerance);
        Assert.That(isRight, Is.False);
    }
}