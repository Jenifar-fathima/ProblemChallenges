namespace ConditionalEvenProblem
{
    class ConditionalEven
    {
        public static void Solution()
        {
            Console.Write("Enter the number 1 :");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            Console.Write("Enter the number 2 :");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);

            if((IsNum1 && IsNum2) && (nNum1 % 2 == 0 && nNum2 % 2 == 0))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
        }
    }
}
