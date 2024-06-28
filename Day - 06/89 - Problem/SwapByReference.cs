namespace SwapByReferenceProblem
{
    class SwapByReference
    {
        public static void Solution()
        {
            Console.Write("Enter the value 1:");
            _ = int.TryParse(Console.ReadLine(), out int nNumber1);
            Console.Write("Enter the value 2:");
            _ = int.TryParse(Console.ReadLine(), out int nNumber2);
            Console.WriteLine($"Before passing reference parameter :A-{nNumber1} | B-{nNumber2}");
            DoubleTheNumber(ref nNumber1,ref nNumber2);
            Console.WriteLine($"Before passing reference parameter :A-{nNumber1} | B-{nNumber2}");
        }
        public static void DoubleTheNumber( ref int num1,ref int num2)
        {
            (num1, num2) = (num2, num1);
        }
    }
}
