namespace ProblemChallenges.Day___04._59___Problem
{
    class ConditionalOperatorNested
    {
        public static void Solution()
        {
            bool bIsNumber1 = int.TryParse(Console.ReadLine(), out int nNumber1);
            bool bIsNumber2 = int.TryParse(Console.ReadLine(), out int nNumber2);

            if (bIsNumber1 && bIsNumber2)
            {
                Console.WriteLine((nNumber1 > 0) && (nNumber2 > 0) ? 2 :
                    (nNumber1 > 0) || (nNumber2 > 0) ? 1 : 0 );
            }
        }
    }
}
