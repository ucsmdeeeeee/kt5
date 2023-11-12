interface IShape
{
    double Area { get; }
    double Perimeter { get; }
    void Calculate();
}
public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public double Perimeter => Math.PI * Radius * 2;
    public void Calculate()
    {
        Console.WriteLine($"площадь круга = {Area}, периметр круга = {Perimeter}");
    }
}
public class Rectangle : IShape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area => Height * Width;
    public double Perimeter => (Height + Width) * 2;
    public void Calculate()
    {
        Console.WriteLine($"площадь прямоугольника = {Area}, периметр прямоугольника = {Perimeter}");
    }
}
public class Triangle : IShape
{
    public double Footing { get; set; }
    public double Height { get; set; }
    public double Area => (Footing * Height)/2;
    public double Perimeter => (Area * 2) / Footing;
    public void Calculate()
    {
        Console.WriteLine($"площадь треугольника = {Area}, периметр треугольника = {Perimeter}");
    }
}
class Program2
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();
        circle.Radius = 1;
        rectangle.Height = 1;
        rectangle.Width = 1;
        triangle.Footing = 1;
        triangle.Height = 1;
        circle.Calculate();
        rectangle.Calculate();
        triangle.Calculate();
    }
}