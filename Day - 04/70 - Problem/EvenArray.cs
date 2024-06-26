namespace EvenArrayProblem
{
    class EvenArray
    {
        public static void Solution()
        {
            Console.Write("Enter the number of element :");
            _ = int.TryParse(Console.ReadLine(), out int nElements);

            int[] lstArray = new int[nElements];
            
            for (int i = 0; i < nElements; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
            }
            for(int i = 0;i < nElements; i++) 
            {
                if (lstArray[i] % 2 == 0)
                {
                    Console.Write("{0} ", lstArray[i]);
                }
            }
        }
    }
}
