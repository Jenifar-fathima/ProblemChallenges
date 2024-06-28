namespace FahrenheitToCelciusProblem
{
    class FahrenheitToCelcius
    {
        public static void Solution()
        {
            Console.Write("Enter the temperature in Fahrenheit :");
            float nFahrenheit = Convert.ToSingle(Console.ReadLine());

            float nCelcius = (nFahrenheit - 32 ) * 5 / 9;
            Console.WriteLine($"Celcius To Fahrenheit :{nCelcius}");
        }
    }
}
