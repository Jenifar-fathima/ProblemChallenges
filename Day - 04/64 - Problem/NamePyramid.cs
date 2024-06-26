namespace NamePyramidProblem
{
    class NamePyramid
    {
        public static void Solution()
        {
            string? strName = Console.ReadLine();
            
            int nLength = strName.Length;
            int middleIndex = nLength / 2;

            for (int i = 0; i <= middleIndex; i++)
            {
                for (int j = 0; j < middleIndex - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = middleIndex - i; j <= middleIndex + i; j++)
                {
                    if (j < nLength)
                    {
                        Console.Write(strName[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
