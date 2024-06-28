//Print All Multiplication Tables (1 to 10)
namespace MulTableProblem
{
    class MulTable
    {
        public static void Solution()
        {
            for(int j=1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{j} X {i} = {j * i}");
                }Console.WriteLine();   
            }
        }
    }
}
