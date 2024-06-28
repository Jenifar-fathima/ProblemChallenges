namespace WriteTitleProblem
{
    class WriteTitle
    {
        public static void Solution()
        {
            Console.Write("Enter the text :");
            string strWord = Console.ReadLine();

            TitleWord(strWord);
        }
        public static void TitleWord(string strWord)
        {
            strWord = strWord.ToUpper();
            for(int i = 0; i < 3; i++)
            {
                if (i == 0 || i == 2)
                {
                    for (int j = 0; j < 3 * strWord.Length; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < strWord.Length; j++)
                    {
                        Console.Write($" {strWord[j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
