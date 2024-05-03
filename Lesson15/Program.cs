namespace Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Singleton.Instance.DoSomething();
            Console.WriteLine();

            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();
            car.Drive();

            VehicleFactory bikeFactory = new BikeFactory();
            IVehicle bike = bikeFactory.CreateVehicle();
            bike.Drive();
            Console.WriteLine();

            WeatherStation weatherStation = new WeatherStation();
            TemperatureDisplay temperatureDisplay = new TemperatureDisplay();

            weatherStation.Attach(temperatureDisplay);
            weatherStation.Temperature = 26;

            Console.ReadKey();
        }
    }
}