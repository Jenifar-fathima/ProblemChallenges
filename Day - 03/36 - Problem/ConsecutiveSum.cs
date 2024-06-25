namespace ConsecutiveSumProblem
{
    class ConsecutiveSum
    {
        public static void Solution()
        {
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);
            int nSum = 0;
            if (IsNum1 && IsNum2)
            {
                for(int i = 0; i < nNum1;i++) 
                {
                    nSum += nNum2;
                }
                Console.WriteLine("{0} X {1} = {2}", nNum1, nNum2, nSum);
            }
        }
    }
}
