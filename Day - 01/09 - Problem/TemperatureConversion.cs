namespace TemperatureConversionProblem
{
    class TemperatureConversion
    {
        public static void Solution()
        {
            Console.Write("Enter the celcius value:");
            float fCelciusValue = Convert.ToInt32(Console.ReadLine());

            float fKelvin = fCelciusValue + 273;
            float fFahrenHeit = fCelciusValue * 18 / 10 + 32;

            Console.WriteLine("Kelvin :" + fKelvin);
            Console.WriteLine("FahrenHeit :" + fFahrenHeit);
        }
    }
}
