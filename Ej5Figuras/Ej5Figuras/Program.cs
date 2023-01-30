using Ej5Figuras;

internal class Program
{
    private static void Main(string[] args)
    {
        GLBCircle circle = new(4);
        Console.WriteLine(circle.PrintMessage()); 
        GLBTriangle triangle = new(3, 4);
        Console.WriteLine(triangle.PrintMessage());
        GLBSquare square = new(5);
        Console.WriteLine(square.PrintMessage());
    }
}