//Calculate Sum of Numbers from 1 to 10
namespace SumCalProblem
{
    class SumCal
    {
        public static void Solution()
        {
            int nSum = 0;
            for(int i = 1; i <= 10; i++)
            {
                nSum += i;
            }
            Console.WriteLine("Sum :{0}",nSum);
        }
    }
}
