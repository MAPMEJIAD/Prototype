namespace Prototype;

public abstract class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public abstract Car Clone();
    }