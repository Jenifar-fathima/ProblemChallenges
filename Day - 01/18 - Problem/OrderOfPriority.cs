namespace OrderOfPriorityProblem
{
    class OrderOfPriority
    {
        public static void Solution()
        {
            Console.Write("Enter the value :");
            int nNum = Convert.ToInt32(Console.ReadLine());

            int nProblem1 = -6 + nNum * 5;
            int nProblem2 = (13 - 2) * nNum;
            int nProblem3 = (nNum + -2) * (20 / 10);
            int nProblem4 = (12 + nNum) / (5 - 4);

            Console.WriteLine("Output :\n1. {0}\n2. {1}\n3. {2}\n4. {3}", nProblem1, nProblem2, nProblem3, nProblem4);
        }
    }
}
