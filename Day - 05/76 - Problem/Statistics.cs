namespace StatisticsProblem
{
    class Statistics
    {
        public static void Solution()
        {
            int nRange = 1000;
            int nCount = 0;
            int[] lstNumbers = new int[nRange];
            int nChoice;
            do
            {
                Console.WriteLine("1. Add\n2. Show\n3. Search\n4. Statistics\n5. Exit");
                Console.WriteLine("Enter the choice :");
                _ = int.TryParse(Console.ReadLine(), out nChoice);
                switch (nChoice)
                {
                    case 1:
                        if(nCount < nRange)
                        {
                            _ = int.TryParse(Console.ReadLine(), out lstNumbers[nCount]);
                            nCount++;
                        }
                        else
                        {
                            Console.WriteLine("Array is full!!");
                        }
                        
                        break;

                    case 2:
                        if (nCount > 0)
                        {
                            for(int i = 0;i<nCount;i++)
                            {
                                Console.Write($"{lstNumbers[i]} ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Array is empty!!");
                        }
                        break;

                    case 3:
                        if (nCount > 0)
                        {
                            Console.Write("Enter the element to search :");
                            _ = int.TryParse(Console.ReadLine(), out int nSearch);
                            bool bIsFound = false;
                            int nIndex = 0;
                            for (int i = 0; i < nCount; i++)
                            {
                                if (lstNumbers[i] == nSearch)
                                {
                                    bIsFound = true;
                                    nIndex = i;
                                }
                            }
                            if (bIsFound)
                            {
                                Console.WriteLine($"Element is found at the position {nIndex + 1}");
                            }
                            else
                            {
                                Console.WriteLine("Element not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("array is empty!!");
                        }
                        break;

                    case 4:
                        int nSum = 0;
                        int nMin = lstNumbers[0];
                        int nMax = lstNumbers[0];

                        foreach (int i in lstNumbers)
                        {
                            nSum += i;
                        }
                        Console.WriteLine("Total Count :{0}", nCount);
                        Console.WriteLine("Sum :{0}", nSum);
                        Console.WriteLine("Average :{0}", nSum / lstNumbers.Length);

                        for (int i = 0; i < nCount; i++)
                        {
                            if (nMin > lstNumbers[i])
                            {
                                nMin = lstNumbers[i];
                            }
                            if (nMax < lstNumbers[i])
                            {
                                nMax = lstNumbers[i];
                            }
                        }
                        Console.WriteLine("Minimum value :{0}\nMaximum value :{1}", nMin, nMax);
                        break;

                    case 5:
                        Console.WriteLine("Bye bye!!");
                        break;
                }
            } while (nChoice != 5);
        }
    }
}
