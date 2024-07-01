namespace MaxNumArrayProblem
{
    class MaxNumArray
    {
        public static void Solution()
        {
            Console.Write("Enter the range :");
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            int[] lstNumArray = new int[nRange];
            int nMax = lstNumArray[0];
            for (int i = 0; i < nRange; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstNumArray[i]);
                if(lstNumArray[i] > nMax)
                {
                    nMax = lstNumArray[i];
                }
            }
            Console.WriteLine($"Maximun number in the array is :{nMax}");
        }
    }
}
