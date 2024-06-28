namespace PalindromeProblem
{
    class Palindrome
    {
        public static void Solution()
        {
            Console.Write("Enter the text :");
            string strText = Console.ReadLine();

            bool bIsPalindrome = IsPalindrome(strText);
            Console.WriteLine(bIsPalindrome);
        }
        public static bool IsPalindrome(string strText)
        {
            strText = strText.ToUpper();
            int nLen = strText.Length;
            int nLast = nLen - 1;

            for (int i = 0; i < nLast; i++)
            {
                if (strText[i] != strText[nLast - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}