namespace ReverseStringFunctionProblem
{
    class ReverseStringFunction
    {
        public static void Solution()
        {
            Console.Write("Enter the string :");
            string strWord = Console.ReadLine();
            string strReversedWord = ReverseString(strWord);
            Console.WriteLine($"Reversed string :{strReversedWord}");
        }
        public static string ReverseString( string word ) 
        {
            string reversed = "";
            for(int i= word.Length-1; i>=0; i--)
            {
                reversed += word[i];
            }
            return reversed;
        }
    }
}
