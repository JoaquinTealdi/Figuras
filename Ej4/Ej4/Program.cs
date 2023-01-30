using Ej4;

internal class Program
{
    private static void Main(string[] args)
    {
        Numbers number = new();
        Console.WriteLine(number.Generate());
        Console.WriteLine("The amount of positives numbers is: " + number.PositiveNumbers());
        Console.WriteLine("The amount of zero numbers is: " + number.ZeroNumbers());
        Console.WriteLine("The sum of negatives numbers is:" + number.NegativeSum());
        Console.WriteLine("The most common number is " + number.Repeated());
        Console.WriteLine("End");
        Console.Read();
    }
}