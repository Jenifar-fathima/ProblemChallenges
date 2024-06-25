namespace DrawTriangleProblem
{
    class DrawTriangle
    {
        public static void Solution()
        {
            Console.Write("Enter the Number :");
            bool IsNum = int.TryParse(Console.ReadLine(), out int nNum);
            Console.Write("Enter the range Number :");
            bool IsRange = int.TryParse(Console.ReadLine(), out int nRange);

            if(IsNum && IsRange)
            {
                for(int i = nRange; i >= 0; --i) 
                {
                    for(int j = 0; j < i; ++j)
                    {
                        Console.Write(nNum);
                    }Console.WriteLine();
                }
            }
        }
    }
}
