namespace StarPyramidPyramidProblem
{
    class StarPyramid
    {
        public static void Solution()
        {
            bool bIsHeight = int.TryParse(Console.ReadLine(), out int nHeight);
            string? strSymbol = Console.ReadLine();

            if (bIsHeight)
            {
                int nCount = nHeight - 1;
                for(int i = 1; i <= nHeight; i++) 
                {
                    for(int j = 1; j <= nCount; j++)
                    {
                        Console.Write(" ");
                    }nCount--;
                    for(int k = 1; k <= 2*i - 1; k++)
                    {
                        Console.Write(strSymbol);
                    }Console.WriteLine();
                }
            }
        }
    }
}
