using FiguresLibrary.Interfaces;

namespace FiguresLibrary.Figures;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IFigure
{
    public Circle(double radius) => Radius = radius;
    
    /// <summary>
    /// Радиус круга.
    /// </summary>
    public double Radius { get; set; }

    public double GetArea() => Math.PI * Radius * Radius;
}