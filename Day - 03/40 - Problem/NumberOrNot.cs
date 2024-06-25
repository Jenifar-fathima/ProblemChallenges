namespace NumberOrNotProblem
{
    class NumberOrNot
    {
        public static void Solution()
        {
            bool IsNum = int.TryParse(Console.ReadLine(), out int nNum);

            if (IsNum)
            {
                Console.WriteLine("It is a number");
            }
            else
            {
                Console.WriteLine("It is not a number");
            }
        }
    }
}
