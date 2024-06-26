namespace InfiniteDivisionsProblem
{
    class InfiniteDivisions
    {
        public static void Solution()
        {
            int nNum1, nNum2, nQuotient, nRemainder;
            
            do
            {
                Console.Write("Enter the first Number :");
                _ = int.TryParse(Console.ReadLine(), out nNum1);
                
                if (nNum1 != 0)
                {
                    Console.Write("Enter the second Number :");
                    _ = int.TryParse(Console.ReadLine(), out nNum2);

                    if (nNum2 == 0)
                    {
                        Console.WriteLine("Cannot divide number by 0");
                    }
                    else
                    {
                        nQuotient = nNum1 / nNum2;
                        nRemainder = nNum1 % nNum2;
                        Console.WriteLine("The division is {0}\nThe rest is {1}", nQuotient, nRemainder);
                    }
                }
            } while (nNum1!=0);
            if(nNum1 == 0) 
            {
                Console.WriteLine("Bye!!");
            }
        }
    }
}
