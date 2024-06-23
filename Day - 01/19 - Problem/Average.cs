namespace AverageProblem
{
    class Average
    {
        public static void Solution()
        {
            Console.Write("Enter Number 1 :");
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 :");
            int nNum2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 3 :");
            int nNum3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 4 :");
            int nNum4 = Convert.ToInt32(Console.ReadLine());

            int nResult = (nNum1 + nNum2 + nNum3 + nNum4) / 4;
            Console.WriteLine("Average :{0}", nResult);
        }
        
    }
}
