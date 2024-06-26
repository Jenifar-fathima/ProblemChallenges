namespace ReverseArrayProblem
{
    class ReverseArray
    {
        public static void Solution()
        {
            Console.Write("Enter the array size :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstArray = new int[nRange];
            for(int i = 0; i < nRange; i++) 
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
            }
            for(int i = nRange-1; i > 0; i--)
            {
                Console.Write("{0} ",lstArray[i]);
            }
        }
    }
}
