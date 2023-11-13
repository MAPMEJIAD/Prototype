namespace Prototype;

public class SUV : Car
{
    public SUV(string model, string color, int year)
    {
        Model = model;
        Color = color;
        Year = year;
    }

    public override Car Clone()
    {
        return (Car)MemberwiseClone();
    }
}