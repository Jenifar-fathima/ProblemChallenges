namespace CheckPrimeProblem;
class CheckPrime
{
    public static void Solution()
    {
        Console.Write("Enter the Number");
        bool IsNum = int.TryParse(Console.ReadLine(), out int nNum);

        if (IsNum)
        {
            int nDivider;

            for (nDivider = 2; nNum % nDivider != 0; nDivider++){}
            if (nDivider == nNum)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }
    }
}
