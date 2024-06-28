//Positive Numbers in an Array
namespace PositiveArrayProblem
{
    class PositiveArray
    {
        public static void Solution()
        {
            Console.Write("Enter the range :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstNumArray = new int[nRange];
            int nCount = 0;
            int[] lstPositiveArray = new int[nRange];
            for (int i = 0; i < nRange; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstNumArray[i]);
                if(lstNumArray[i] > 0)
                {
                    lstPositiveArray[nCount] = lstNumArray[i];
                    nCount++;
                }
            }
            Console.WriteLine("Positive array is :");
            for(int i =0;i < nCount;i++)
            {
                Console.Write($"{lstPositiveArray[i]} ");
            }
        }
    }
}
