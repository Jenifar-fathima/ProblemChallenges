namespace OddDescendingProblem
{
    class OddDescending
    {
        public static void Solution()
        {
            Console.Write("Enter the Largest Number :");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            Console.Write("Enter the Smallest Number :");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);

            if(IsNum1 && IsNum2)
            {
                if(nNum1 % 2 == 0)
                {
                    nNum1--;
                }
                for(int i = nNum1; i>= nNum2; i -= 2)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
