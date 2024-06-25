namespace MathematicalStatisticsProblem
{
    class MathematicalStatistics
    {
        public static void Solution()
        {
            int nTotal = 5;
            int[] lstNumbers = new int[nTotal];

            for (int i = 0; i < nTotal; i++)
            {
                lstNumbers[i] = int.Parse(Console.ReadLine());
            }

            int nSum = 0,
                nAverage = 0,
                nMax = int.MinValue,
                nMin = int.MaxValue;

            for (int i = 0; i < nTotal; i++)
            {
                int nNum = lstNumbers[i];

                nSum += nNum;

                if (nNum > nMax)
                {
                    nMax = nNum;
                }

                if (nNum < nMin)
                {
                    nMin = nNum;
                }
            }

            nAverage = nSum / nTotal;

            Console.WriteLine("Sum: " + nSum);
            Console.WriteLine("Average: " + nAverage);
            Console.WriteLine("Max: " + nMax);
            Console.WriteLine("Min: " + nMin);
        }
    }
}