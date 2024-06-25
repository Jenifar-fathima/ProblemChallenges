namespace InfiniteSumProblem
{
    class InfiniteSum
    {
        public static void Solution()
        {
            int nValue;
            int nSum = 0;

            do
            {
                bool IsnNum = int.TryParse(Console.ReadLine(),out nValue);
                if (IsnNum)
                {
                    nSum = nValue + nSum;
                }
                
                if (nValue != 0)
                    Console.WriteLine(nSum);
            }
            while (nValue != 0);

            Console.WriteLine("Finished");
        }
    }
}
