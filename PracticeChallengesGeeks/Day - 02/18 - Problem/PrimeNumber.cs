namespace PrimeNumberProblem
{
    class PrimeNumber
    {
        public static void Solution()
        {
            
            _ = int.TryParse(Console.ReadLine(), out int nInitial);
            _ = int.TryParse(Console.ReadLine(), out int nFinal);

            while (nInitial < nFinal)
            {
                if (IsPrime(nInitial))
                {
                    Console.Write(nInitial + " ");
                }
                nInitial++;
            }
        }
        public static bool IsPrime( int num )
        {
            int nDivider = 2;
            while(num % nDivider != 0) 
            {
                nDivider++; 
            }
            if (nDivider == num)
            {
                return true;
            }
            return false;
        }
    }
}
