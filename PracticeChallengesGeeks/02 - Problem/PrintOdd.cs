//Print Odd Numbers Less Than 100
using System.Data;

namespace PrintOddProblem
{
    class PrintOdd
    {
        public static void Solution()
        {
            for(int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
