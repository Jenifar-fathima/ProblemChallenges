namespace ParallelogramProblem
{
    class Parallelogram
    {
        public static void Solution()
        {
            bool bIsWidth = int.TryParse(Console.ReadLine(), out int nWidth);
            bool bIsHeight = int.TryParse(Console.ReadLine(), out int nHeight);
            string? strSymbol = Console.ReadLine();

            if(bIsWidth && bIsHeight) 
            {
                int nCount = 1;
                for(int  i = 1; i <= nHeight; i++)
                {
                    for(int j = 1; j <= nCount; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k <= nWidth; k++)
                    {
                        Console.Write(strSymbol);
                    }nCount++;
                    Console.WriteLine();
                }
            }
        }
    }
}
