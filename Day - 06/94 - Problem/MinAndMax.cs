namespace MinAndMaxProblem
{
    class MinAndMax
    {
        public static void Solution()
        {
            Console.Write("Enter the range :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstNumbers = new int[nRange];
            for (int i = 0; i < nRange; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstNumbers[i]);
            }
            int nMin = 0;
            int nMax = 0;
            MinMax(ref lstNumbers,ref nMin,ref nMax);
            Console.WriteLine("Minimum value :{0}\nMaximum value :{1}", nMin, nMax);
        }
        public static void MinMax(ref int[] numberArray,ref int min,ref int max)
        {
            min = numberArray[0];
            max = numberArray[0];


            for (int i = 0; i < numberArray.Length; i++)
            {
                if (min > numberArray[i])
                {
                    min = numberArray[i];
                }
                if (max < numberArray[i])
                {
                    max = numberArray[i];
                }
            }
        }
    }
}