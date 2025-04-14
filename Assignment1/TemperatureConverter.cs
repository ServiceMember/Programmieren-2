namespace Assignment1;

public class TemperatureConverter
{
    public static double ConvertTemperature(double temperature, char unit)
    {
        switch (unit)
        {
            case 'C':
                return (temperature * 9 / 5) + 32; // Celsius to Fahrenheit
            case 'F':
                return (temperature - 32) * 5 / 9; // Fahrenheit to Celsius
            default:
                throw new ArgumentException("Invalid unit. Use 'C' for Celsius or 'F' for Fahrenheit.");
        }
    }
}