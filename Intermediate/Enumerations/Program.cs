var temperature = new Temperature(TemperatureUnit.Celsius, 10);

Console.WriteLine((int)TemperatureUnit.Celsius);
Console.WriteLine((int)TemperatureUnit.Fahrenheit);
Console.WriteLine((int)TemperatureUnit.Kelvin);

int temperature2 = 7;
TemperatureUnit kelvin = (TemperatureUnit)temperature2;
Console.WriteLine(kelvin);

enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInCelsius 
    { 
        get 
        {
            if (Unit == TemperatureUnit.Celsius)
            {
                return Value;
            }

            if (Unit == TemperatureUnit.Fahrenheit)
            {
                return (Value - 32) * 5 / 9;
            }

            if (Unit == TemperatureUnit.Kelvin)
            {
                return Value - 273.15m;
            }

            return 0;
        }
    }

}