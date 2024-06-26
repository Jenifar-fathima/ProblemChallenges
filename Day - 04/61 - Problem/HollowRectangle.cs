namespace HollowRectangleProblem
{
    class HollowRectangle
    {
        public static void Solution()
        {
            bool bIsValue = int.TryParse(Console.ReadLine(), out int nValue);
            bool bIsRow = int.TryParse(Console.ReadLine(), out int nRow);
            bool bIsColumn = int.TryParse(Console.ReadLine(), out int nColumn);
            int nCount = 1;
            if (bIsRow && bIsValue && bIsColumn)
            {
                for (int i = 1; i <= nRow; i++)
                {
                    if (nCount == 1 || nCount == nRow)
                    {
                        for (int j = 1; j <= nColumn; j++)
                        {
                            Console.Write(nValue);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int k = 1; k <= nColumn; k++)
                        {
                            if (k == 1 || k == nColumn)
                            {
                                Console.Write(nValue);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();

                    }
                    nCount++;
                }
            }
        }
    }
}
