using System.Security.Cryptography;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        int radius = 5;
        Circle c = new(radius);
        Console.WriteLine($"{radius} * {radius} * {Circle.PI} = {c.AreaCalculation()}");
        Console.WriteLine($"{radius} * {radius} * {Circle.PI} = {Circle.AreaCalculation(radius)}");
        Circle.PI = 3;
        Console.WriteLine($"{radius} * {radius} * {Circle.PI} = {c.AreaCalculation()}");
        Console.WriteLine($"{radius} * {radius} * {Circle.PI} = {Circle.AreaCalculation(radius)}");

    }
}
