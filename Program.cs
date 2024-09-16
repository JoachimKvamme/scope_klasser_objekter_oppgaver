namespace scope_klasser_objekter_forelesning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.AddNumbers(20, 10));
        Console.WriteLine(calculator.SubtractNumbers(20, 10));
    }
}
