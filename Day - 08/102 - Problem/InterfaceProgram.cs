namespace InterfaceProgramProblem;
public class InterfaceProgram
{
    public static void Solution()
    {
        Car car = new Car(0);

        int nFuel = int.Parse(Console.ReadLine());
        if (car.Refuel(nFuel))
        {
            car.Drive();
        }
    }

    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int nAmount)
        {
            Fuel += nAmount;
            return true;
        }
    }
}