namespace ArraySearchProblem
{
    class ArraySearch
    {
        public static void Solution()
        {
            Console.Write("Enter the number of element :");
            _ = int.TryParse(Console.ReadLine(),out int nElements);

            int[] lstArray = new int[nElements];
            bool bIsFound = false;

            for(int i = 0; i < nElements; i++)
            {
                _ = int.TryParse(Console.ReadLine(), out lstArray[i]);
            }

            Console.Write("Enter the element to search :");
            _ = int.TryParse(Console.ReadLine(), out int nSearch);
            Console.WriteLine("End");

            for(int i = 0;i < nElements;i++)
            {
                if (lstArray[i] == nSearch)
                {
                    bIsFound = true;
                } 
            }

            if( bIsFound ) 
            {
                Console.WriteLine("{0} is Found", nSearch);
            }
            else
            {
                Console.WriteLine("{0} is not Found", nSearch);
            }
        }
    }
}
