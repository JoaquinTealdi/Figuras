using Ejercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        Numbers numbers = new Numbers();
        Console.WriteLine(numbers.Generate());
        Console.WriteLine("The amount of positives numbers is: " + numbers.PositiveNumbers()); 
        Console.WriteLine("The amount of zero numbers is: " + numbers.ZeroNumbers());
        Console.WriteLine("The sum of negatives numbers is:" + numbers.NegativeSum()); 
        Console.WriteLine("The most common number is " + numbers.Repeated()); 
        Console.WriteLine("End");
        Console.Read();
    }
}