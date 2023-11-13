namespace Prototype;

public class CarFactory
{
    private readonly Car sedanPrototype;
    private readonly Car suvPrototype;

    public CarFactory()
    {
        
        sedanPrototype = new Sedan("Sedan", "Red", 2020);
        suvPrototype = new SUV("SUV", "Blue", 2021);
    }

    public Car CreateSedan()
    {
        // Получение клонированного прототипа седана
        return sedanPrototype.Clone();
    }

    public Car CreateSUV()
    {
        // Получение клонированного прототипа внедорожника
        return suvPrototype.Clone();
    }
}