//Sum of Numbers in an Array
namespace NumArraySumProblem
{
    class NumArraySum
    {
        public static void Solution()
        {
            Console.Write("Enter the range :");
            _=int.TryParse(Console.ReadLine() , out int nRange);
            int[] lstNumArray = new int[nRange];
            int nSum = 0;
            for(int i = 0; i < nRange; i++)
            {
                _= int.TryParse(Console.ReadLine(), out lstNumArray[i]);
                nSum += lstNumArray[i];
            }
            Console.WriteLine($"Sum of the array :{nSum}");
        }
    }
}
