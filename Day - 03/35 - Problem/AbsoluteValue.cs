namespace AbsoluteValueProblem
{
    class AbsoluteValue
    {
        public static void Solution()
        {
            Console.Write("Enter the value :");

            bool IsNum = int.TryParse(Console.ReadLine(), out int nNum);

            if (IsNum)
            {
                if (nNum < 0)
                {
                    Console.WriteLine("Absolute value is {0}",-nNum);
                }
                else
                {
                    Console.WriteLine("Absolute value is {0}",nNum);
                }
            }
        }
    }
}
