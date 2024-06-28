namespace OddSumProblem
{
    class OddSum
    {
        public static void Solution()
        {
            int nSum = 0;
            for(int i = 10; i <= 30; i++) 
            {
                if(i % 2 != 0)
                {
                    nSum += i;
                }
            }Console.WriteLine($"Sum of odd numbers from 10 to 30 is {nSum}");
        }
    }
}
