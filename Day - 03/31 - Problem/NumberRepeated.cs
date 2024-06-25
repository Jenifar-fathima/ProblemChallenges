namespace NumberRepeatedProblem
{
    class NumberRepeated
    {
        public static void Solution()
        {
            Console.Write("Enter the value :");
            bool IsValue = int.TryParse(Console.ReadLine(), out int nValue);
            Console.Write("How many times the value to be printed :");
            bool IsRange = int.TryParse(Console.ReadLine(), out int nRange);
            if(IsValue && IsRange) 
            {
                for (int i = 0; i < nRange; i++)
                {
                    Console.Write(nValue);
                }
            }
        }
    }
}
