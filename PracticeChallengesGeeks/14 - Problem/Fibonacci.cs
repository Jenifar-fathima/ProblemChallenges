namespace FibonacciProblem
{
    class Fibonacci
    {
        public static void Solution()
        {
            int nCount = 10; 
            int[] lstFibonacci = new int[nCount];
            lstFibonacci[0] = 0;
            lstFibonacci[1] = 1;

            for (int i = 2; i < nCount; i++)
            {
                lstFibonacci[i] = lstFibonacci[i - 1] + lstFibonacci[i - 2];
            }

            Console.WriteLine("The first 10 Fibonacci numbers are:");
            foreach (int num in lstFibonacci)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
