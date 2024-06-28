namespace DoubleNumberProblem
{
    class DoubleNumber
    {
        public static void Solution()
        {
            Console.Write("Enter the number :");
            _ = int.TryParse(Console.ReadLine(), out int nNumber);

            int nResult = DoubleTheNumber(nNumber);
            Console.WriteLine(nResult);
        }
        public static int DoubleTheNumber(int nNumber)
        {
            return nNumber * 2;
        }
    }
}
