namespace CheckVowelsProblem
{
    class CheckVowels
    {
        public static void Solution()
        {
            Console.Write("Enter the character :");
            string? strCharacter = Console.ReadLine();

            switch(strCharacter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("It is vowel");
                    break;

                default:
                    Console.WriteLine("It is not vowel");
                    break;

            }
        }
    }
}
