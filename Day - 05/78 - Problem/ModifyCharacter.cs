namespace ModifyCharacterProblem
{
    class ModifyCharacter
    {
        public static void Solution()
        {
            string strWord = Console.ReadLine();
            _=int.TryParse(Console.ReadLine(), out int nPosition);
            char cLetter = (char)Console.Read();
            string strResult = AlterCharacter(strWord, nPosition, cLetter);
            Console.WriteLine(strResult);
        }
        public static string AlterCharacter(string text,int position,char letter)
        {
            char[] strModified = new char[text.Length];
            string strNewWord = "";
            
            for (int i = 0; i < text.Length; i++)
            {
                strModified[i] = text[i]; 
            }

            strModified[position - 1] = letter;
            for (int i = 0; i < strModified.Length;i++)
            {
                strNewWord += strModified[i];
            }
            return strNewWord;
        }
    }
}
