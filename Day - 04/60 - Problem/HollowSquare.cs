namespace HollowSquareProblem
{
    class HollowSquare
    {
        public static void Solution()
        {
            bool bIsRow = int.TryParse(Console.ReadLine(), out int nRow);
            bool bIsValue = int.TryParse(Console.ReadLine(), out int nValue);
            int nCount = 1;
            if (bIsRow && bIsValue)
            {
                for(int i = 1; i <= nRow; i++) 
                { 
                    if(nCount == 1 || nCount== nRow)
                    {
                        for(int j = 1; j <= nRow; j++)
                        {
                            Console.Write(nValue);
                        }
                        Console.WriteLine();
                    }
                    else 
                    { 
                        for(int  k = 1; k <= nRow; k++)
                        {
                            if(k == 1 || k == nRow)
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
