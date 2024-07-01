namespace PrimeCheckProblem
{
    class PrimeCheck
    {
        public static void Solution()
        {
            Console.Write("Enter the Number :");
            _ = int.TryParse(Console.ReadLine(), out int nNumber);
            bool bIsPrime = CheckPrimeProblem(nNumber);
            Console.WriteLine(bIsPrime);
        }
        public static bool CheckPrimeProblem(int number)
        {
            int divisor = 2;
            while (number % divisor != 0) 
            {
                divisor++;
            }
            if(number == divisor)
            {
                return true;
            }
            return false;
        }
    }
}
