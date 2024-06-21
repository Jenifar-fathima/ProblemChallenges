namespace SphereCalculationProgram
{
    class SphereCalculation
    {
        public static void Solution()
        {
            Console.Write("Enter the value: ");
            double nValue = Convert.ToInt32(Console.ReadLine());
            double dSurfaceValue = 4 * Math.PI * Math.Pow(nValue,2);

            double dVolume =  4 / 3 * Math.PI * Math.Pow(nValue, 3);

            Console.WriteLine("Surface :" + dSurfaceValue);
            Console.WriteLine("Volume :" + dVolume);
        }
    }
}
