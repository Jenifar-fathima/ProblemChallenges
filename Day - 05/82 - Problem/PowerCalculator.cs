namespace PowerCalculatorProblem
{
    class PowerCalculator
    {
        public static void Solution()
        {
            Console.Write("Enter the base number");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the exponent number");
            int nExponent = Convert.ToInt32(Console.ReadLine());

            int nPower = Power(nNumber, nExponent);
            Console.WriteLine(nPower);
        }

        public static int Power(int number, int exponent)
        {
            int nResult = 1;

            for (int i = 0; i < exponent; i++)
            {
                nResult *= number;
            }
            return nResult;
        }
    }
}
