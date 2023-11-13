namespace Prototype;

public class Sedan : Car
    {
        public Sedan(string model, string color, int year)
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