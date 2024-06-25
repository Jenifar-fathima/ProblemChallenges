namespace DisplayFunctionProblem
{
    class DisplayFunction
    {
        public static void Solution()
        {
            Console.Write("Enter the starting Number :");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            Console.Write("Enter the ending Number :");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);

            if(IsNum1 && IsNum2)
            {
                for(int i = nNum1; i <= nNum2; i++)
                {
                    int nValue = (i - 4) * (i - 4);
                    for(int j = 1; j <= nValue; j++)
                    {
                        Console.Write("*");
                    }Console.WriteLine();
                } 
            }
        }
    }
}
