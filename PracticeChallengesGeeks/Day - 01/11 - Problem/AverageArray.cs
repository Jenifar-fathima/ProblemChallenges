//Average of Numbers in an Array
namespace AverageArrayProblem
{
    class AverageArray
    {
        public static void Solution()
        {
            Console.Write("Enter the range :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstNumArray = new int[nRange];
            float nSum = 0.0f;
            for (int i = 0; i < nRange; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstNumArray[i]);
                nSum += lstNumArray[i];
            }
            float nAverage = nSum / nRange;
            Console.WriteLine($"Sum of the array :{nAverage}");
        }
    }
}
