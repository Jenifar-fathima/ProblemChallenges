namespace NorthEastTriangleProblem
{
    class NorthEastTriangle
    {
        public static void Solution()
        {
            Console.Write("Enter the row Number :");
            bool IsRow = int.TryParse(Console.ReadLine(), out int nRow);
            int nCount = 1;
            if(IsRow)
            {
                for(int i = 0; i < nRow; i++)
                {
                    for(int j = 0; j < nCount; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 0; k < nRow - i; k++)
                    {
                        Console.Write("*");
                    }nCount++;
                    Console.WriteLine();
                }
            }
        }
    }
}
