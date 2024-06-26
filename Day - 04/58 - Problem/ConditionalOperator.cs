namespace ConditionalOperatorProblem
{
    class ConditionalOperator
    {
        public static void Solution()
        {
            bool bIsNumber1 = int.TryParse(Console.ReadLine(), out int nNumber1);
            bool bIsNumber2 = int.TryParse(Console.ReadLine(), out int nNumber2);

            if(bIsNumber1 && bIsNumber2) 
            {
                Console.WriteLine(nNumber1 > 0 ? "A is Positve" : "A is not Positve");
                Console.WriteLine(nNumber2 > 0 ? "B is Positve" : "B is not Positve");
                Console.WriteLine((nNumber1 > 0) && (nNumber2 > 0) ? "Both are Positve" : "Both are not Positve");
            }
        }
    }
}
