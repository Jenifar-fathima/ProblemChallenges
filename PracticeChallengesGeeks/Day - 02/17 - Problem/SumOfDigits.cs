namespace SumOfDigitsProblem
{
    class SumOfDigits
    {
        public static void Solution()
        {
            Console.Write("Enter the number :");
            _ = int.TryParse(Console.ReadLine(), out int nNumber);

            int nResult = SumDigits(nNumber);
            Console.WriteLine("Sum of digits of a positive integer :{0}",nResult);
        }
        public static int SumDigits(int nNumber)
        {
            int nSum = 0;
            while (nNumber > 0)
            {
                nSum += nNumber % 10;
                nNumber /= 10;
            }
            return nSum;
        }
    }
}
