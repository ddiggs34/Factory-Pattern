namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numWheels;

            Console.WriteLine("How many wheels are on your current vehicle?");

            var userInput = int.TryParse(Console.ReadLine(), out numWheels);


            //classname.static method()

            var vehicle = VehicleFactory.GetVehicle(numWheels);
            vehicle.Drive();
        }
    }
}
