namespace CheckTemperatureConsole;

public class Thermometer
    {
        public double Temperature;

        public void CheckTemperature()
        {
            switch (Temperature)
            {
                case <0:
                    Console.WriteLine("Det är minusgrader");
                    break;
                
                case >= 0 and <= 30:
                    Console.WriteLine("Det är normal temperatur");
                    break;

                default:
                    Console.WriteLine("Varning för hög värme");
                    break;
            }
        }
    }