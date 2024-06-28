//Print Multiplication Table with 7
namespace PrintMulTableProblem
{
    class PrintMulTable
    {
        public static void Solution()
        {
            Console.Write("Enter the table number :");
            _= int.TryParse(Console.ReadLine(), out int nTableNum);
            for(int i = 1;i <= 10; i++)
            {
                Console.WriteLine($"{nTableNum} X {i} = {nTableNum*i}");
            }
        }
    }
}
