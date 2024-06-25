namespace RepetitiveStructureProblem
{
    class RepetitiveStructure
    {
        public static void Solution()
        {
            Console.Write("Enter the starting Number :");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            Console.Write("Enter the ending Number :");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);
            
            if (IsNum1 && IsNum2)
            {
                for(int i = nNum1; i <= nNum2 ; i++ )
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();

                int j = nNum1;
                while (j <= nNum2)
                {
                    Console.Write("{0} ", j);
                    j++;
                }
                Console.WriteLine();

                int k = nNum1;
                do
                {
                    Console.Write("{0} ", k);
                    k++;
                } while (k <= nNum2);
            }
        }
    }
}
