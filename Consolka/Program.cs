
using CalculationSquareLibrary;

class Program 
{
    static void Main() 
    {
        var figure1 = new CalculationSquare(2);
        Console.WriteLine($"Площадь фигуры: { figure1.GetSquare() }");

        var figure2 = new CalculationSquare(4, 4);
        Console.WriteLine($"Площадь фигуры: {figure2.GetSquare()}");

        var figure3 = new CalculationSquare(5, 5, 5);
        Console.WriteLine($"Площадь фигуры: {figure3.GetSquare()}");
    }
}



