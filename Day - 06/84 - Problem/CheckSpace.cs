namespace CheckSpaceProblem
{
    class CheckSpace
    {
        public static void Solution()
        {
            Console.Write("Enter the string :");
            string strSentence = Console.ReadLine();

            int strResult = SpaceCheckMethod(strSentence);
            Console.WriteLine(strResult);
        }
        public static int SpaceCheckMethod(string strSentence)
        {
            int nSpace = 0;
            for(int i = 0; i < strSentence.Length; i++)
            {
                if (strSentence[i] == ' ')
                {
                    nSpace++;
                }
            }
            return nSpace;
        }
    }
}
