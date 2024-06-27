namespace SearchGreatestProblem
{
    class SearchGreatest
    {
        public static void Solution()
        {
            Console.Write("Enter the number of element :");
            _ = int.TryParse(Console.ReadLine(), out int nElements);

            int[] lstArray = new int[nElements];
            Console.WriteLine("Enter the elements :");
            for (int i = 0; i < nElements; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
            }

            int nGreatestNum = GreatestNumber(lstArray);
            Console.WriteLine($"The greatest number from the array is {nGreatestNum}");
        }
        public static int GreatestNumber(int[] lstArray)
        {
            int nMax = lstArray[0];
            if (lstArray.Length > 0)
            {
                for (int i = 0; i < lstArray.Length; i++)
                {
                    if (lstArray[i] > nMax)
                    {
                        nMax = lstArray[i];
                    }
                }
            }
            return nMax;
        }
    }
}
