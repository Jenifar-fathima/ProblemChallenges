namespace ReferenceParameterProblem
{
    class ReferenceParameter
    {
        public static void Solution()
        {
            Console.Write("Enter the number :");
            _ = int.TryParse(Console.ReadLine(), out int nNumber);
            Console.WriteLine($"Before passing reference parameter :{nNumber}");
            DoubleTheNumber(ref nNumber);
            Console.WriteLine($"Before passing reference parameter :{nNumber}");
        }
        public static void DoubleTheNumber(ref int nNumber)
        {
             nNumber *= 2;
        }
    }
}
