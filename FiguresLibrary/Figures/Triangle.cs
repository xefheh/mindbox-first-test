using FiguresLibrary.Interfaces;

namespace FiguresLibrary.Figures;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IFigure
{
    public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c); 
    
    /// <summary>
    /// Первая сторона треугольника.
    /// </summary>
    public double A { get; set; }
    
    /// <summary>
    /// Вторая сторона треугольника.
    /// </summary>
    public double B { get; set; }
    
    /// <summary>
    /// Третья сторона треугольника.
    /// </summary>
    public double C { get; set; }
    
    public double GetArea() =>
        Math.Sqrt((GetPerimeter() / 2) * (GetPerimeter() / 2 - A) * (GetPerimeter() / 2 - B) * (GetPerimeter() / 2 - C));

    /// <summary>
    /// Получение периметра.
    /// </summary>
    /// <returns>Периметр.</returns>
    public double GetPerimeter() => A + B + C;

    /// <summary>
    /// Является ли треугольник прямоугольным?
    /// </summary>
    /// <param name="tolerance">Степень доверия</param>
    /// <returns>True - треугольник прямоугольный, False - нет</returns>
    public bool IsRight(double tolerance) => Math.Abs(A * A + B * B - C * C) <= tolerance ||
                             Math.Abs(A * A + C * C - B * B) <= tolerance ||
                             Math.Abs(B * B + C * C - A * A) <= tolerance;

}