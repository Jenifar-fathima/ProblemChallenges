namespace MultiplicationRangeProblem
{
    class MultiplicationRange
    {
        public static void Solution()
        {
            Console.Write("Enter the initial range :");
            bool IsInit = int.TryParse(Console.ReadLine(), out int nInit);
            Console.Write("Enter the final range :");
            bool IsFinal = int.TryParse(Console.ReadLine(), out int nFinal);
            if (IsInit && IsFinal)
            {
                for (int i = nInit; i <= nFinal; i++)
                {
                    for(int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine("{0} X {1} = {2}", i,j,i*j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
