namespace CheckTemperatureConsole;

class Program
{
    static void Main(string[] args)
    {
        Thermometer weather = new Thermometer();
        Console.WriteLine("Vad är det för temperatur?");
        weather.Temperature = int.Parse(Console.ReadLine()!);

        weather.CheckTemperature();
    }
}
