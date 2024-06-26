namespace PrimeProductProblem
{
    class PrimeProduct
    {
        public static void Solution()
        {
            bool bIsNumber = int.TryParse(Console.ReadLine(), out int nNumber);
            int nFactor = 2;
            if (bIsNumber)
            {
                while (nNumber > 1)
                {
                    while (nNumber % nFactor == 0)
                    {
                        Console.Write("{0} X ", nFactor);
                        nNumber /= nFactor;
                    }
                    nFactor++;
                }
                Console.Write(1);
            }
        }
    }
}
