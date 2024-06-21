namespace StoreUserInputProgram
{ 
    class StoreUserInput
    {
        public static void Solution()
        {
            Console.Write("What is your name?");
            string? strUserName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, {0}",strUserName);
        }
    }
}
