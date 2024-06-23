namespace DivisionFactorProblem
{
    class DivisionFactor
    {
        public static void Solution()
        {
            Console.Write("Enter Divident :");
            int nDivident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor :");
            int nDivisor = Convert.ToInt32(Console.ReadLine());

            int nQuotient = nDivident / nDivisor;
            int nRemainder = nDivident % nDivisor;

            Console.WriteLine("Quotient: {0}\nRemainder: {1}",nQuotient,nRemainder);
        }
    }
}
