namespace CharAlphabetProblem
{
    class CharAlphabet
    {
        public static void Solution()
        {
            char[] cAlpahbet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for(int i = 0; i < cAlpahbet.Length; i++)
            {
                Console.Write("{0} ",cAlpahbet[i]);
            }
        }
    }
}
