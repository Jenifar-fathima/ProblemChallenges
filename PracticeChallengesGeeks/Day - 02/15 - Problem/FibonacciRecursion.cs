namespace FibonacciRecursionProblem
{
    class FibonacciRecursion
    {
        public static void Solution()
        {
            Console.Write("Enter the number of fibonacci sequence :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstFibo = new int[nRange];
            for(int i = 0; i < nRange; i++)
            {
                lstFibo[i] = FiboRecursion(i);
                Console.Write($"{lstFibo[i]} ");
            }
        }
        public static int FiboRecursion(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            return FiboRecursion(x - 1) + FiboRecursion(x - 2);
        }
    }
}
