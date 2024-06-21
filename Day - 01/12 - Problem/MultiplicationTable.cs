namespace MultiplicationTableProblem
{
    class MultiplicationTable
    {
        public static void Solution()
        {
            Console.Write("Enter the number for tables :");
            int nNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"{nNumber} X {i} = {nNumber * i}");
            }
        }
    }
}
