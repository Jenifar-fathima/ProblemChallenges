namespace FunctionAlphaProblem
{
    class FunctionAlpha
    {
        public static void Solution()
        {
            Console.Write("Enter the word :");
            string strWord = Console.ReadLine();

            bool bIsAlpha = IsAlphabetical(strWord);
            Console.WriteLine(bIsAlpha);
        }
        public static bool IsAlphabetical(string strWord)
        {
            strWord = strWord.ToUpper();
            bool bIsTrue = true;
            for (int i = 0; i < strWord.Length; i++)
            {
                if (strWord[i] < 'A' || strWord[i] > 'Z')
                {
                    bIsTrue = false;
                }
            }
            return bIsTrue;
        }
    }
}
