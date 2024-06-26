namespace PositiveNegativeSearchProblem
{
    class PositiveNegativeSearch
    {
        public static void Solution()
        {
            int nElements = 10;
            int[] lstArray = new int[nElements];
            int nArithmeticPositive = 0;
            int nArithmeticNegative = 0;
            int nPositiveCount = 0;
            int nNegativeCount = 0;

            for (int i = 0; i < nElements; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
                if(lstArray[i] > 0 )
                {
                    nArithmeticPositive+= lstArray[i];
                    nPositiveCount++;
                }
                else
                {
                    nArithmeticNegative+= lstArray[i];
                    nNegativeCount++;
                }
            }
            Console.WriteLine("Average Arithmetic Positive :{0}", nArithmeticPositive/ nPositiveCount);
            Console.WriteLine("Average Arithmetic Negative :{0}", nArithmeticNegative/ nNegativeCount);
        }
    }
}
