namespace Prototype;

public class Program
{
    public static void Main(string[] args)
    {
        CarFactory factory = new CarFactory();

        // Создание седана
        Car sedan = factory.CreateSedan();
        Console.WriteLine($"Sedan: {sedan.Model}, {sedan.Color}, {sedan.Year}");

        // Создание внедорожника
        Car suv = factory.CreateSUV();
        Console.WriteLine($"SUV: {suv.Model}, {suv.Color}, {suv.Year}");

        // Изменение состояния седана
        sedan.Color = "Black";
        Console.WriteLine($"Sedan: {sedan.Model}, {sedan.Color}, {sedan.Year}");

        // Проверка, что оригинал и клон являются разными объектами
        Console.WriteLine($"Is sedan the same object as its clone? {ReferenceEquals(sedan, sedan.Clone())}");
    }
}