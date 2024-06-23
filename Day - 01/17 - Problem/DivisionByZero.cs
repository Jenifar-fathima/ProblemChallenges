namespace DivisionByZeroProblem
{
    class DivisionByZero
    {
        public static void Solution()
        {
            Console.Write("Enter Divident :");
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor :");
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("{0} / {1} = {2}", nNum1, nNum2, nNum1 / nNum2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0");
            }
        }

    }
}
