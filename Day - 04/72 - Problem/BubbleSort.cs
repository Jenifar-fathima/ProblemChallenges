﻿namespace BubbleSortProblem
{
    class BubbleSort
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

            for(int i = 0;(i < nElements - 1); i++)
            {
                bool bIsSwapped = false;
                for (int j = 0;j < nElements - 1; j++)
                {
                    
                    if (lstArray[j] > lstArray[j+1])
                    {
                        (lstArray[j], lstArray[j + 1]) = (lstArray[j + 1], lstArray[j]); 
                        bIsSwapped = true;
                    }
                }
                if (!bIsSwapped) break;
            }
            foreach(int i in lstArray)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
