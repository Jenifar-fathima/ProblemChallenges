namespace SumArrayIntegerProblem
{
    class SumArrayInteger
    {
        public static void Solution()
        {
            Console.Write("Enter the number of elements :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstArray = new int[nRange];

            for(int i = 0; i < nRange; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
            }

            int nSumResult = SumArray(lstArray);
            Console.WriteLine($"Sum :{nSumResult}");
        }
        public static int SumArray(int[] lstArray)
        {
            int nSum = 0;
            for(int i = 0;i < lstArray.Length;i++)
            {
                nSum += lstArray[i];
            }
            return nSum;
        }
    }
}
