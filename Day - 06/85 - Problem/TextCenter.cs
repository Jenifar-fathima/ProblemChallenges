namespace TextCenterProblem
{
    class TextCenter
    {
        public static void Solution()
        {
            Console.Write("Enter the string :");
            string strText = Console.ReadLine();

            SpaceCheckMethod(strText);
        }
        public static void SpaceCheckMethod(string strWord)
        {
            strWord = strWord.ToUpper();
            int countSpaces = (80 - strWord.Length) / 2;
            for (int i = 0; i < 2; i++)
            {
                for (i = 0; i < countSpaces; i++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < strWord.Length; j++)
                {
                    Console.Write($" {strWord[j]} ");
                }
                Console.WriteLine();

                for (i = 0; i < countSpaces; i++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 3 * strWord.Length; j++)
                {
                    Console.Write("-");
                }
            }
        }
    }
}
