namespace NameTriangleProblem
{
    class NameTriangle
    {
        public static void Solution()
        {
            Console.Write("Enter the name :");
            string? strName = Console.ReadLine();
            int nLen = strName.Length-1;
            for (int i = nLen; i >= 0; i--)
            {
                for(int j = i; j <= nLen; j++)
                {
                    Console.Write(strName[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
