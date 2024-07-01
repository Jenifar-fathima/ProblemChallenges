namespace CelciusToFahrenheitProblem
{
    class CelciusToFahrenheit
    {
        public static void Solution()
        {
            Console.Write("Enter the temperature in celcius :");
            float nCelcius = Convert.ToSingle(Console.ReadLine());

            float nFahrenheit = (nCelcius * 9 / 5) + 32;
            Console.WriteLine($"Celcius To Fahrenheit :{nFahrenheit}");
        }
    }
}
