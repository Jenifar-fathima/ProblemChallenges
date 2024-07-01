namespace NPrimeNumberProblem
{
    class NPrimeNumber
    {
        public static void Solution()
        {
            int nCount = 0;
            int number = 2;
            while (nCount < 100)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    nCount++;
                }
                number++;
            }

        }
        public static bool IsPrime(int num)
        {
            int nDivider = 2;
            while (num % nDivider != 0)
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
