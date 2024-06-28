namespace FunctionNumberProblem
{
    class FunctionNumber
    {
        public static void Solution()
        {
            Console.Write("Enter the value :");
            string strInteger = Console.ReadLine();

            bool bIsNum = IsNumber(strInteger);
            Console.WriteLine('A');
            Console.WriteLine(bIsNum);
        }
        public static bool IsNumber(string strInteger)
        {
            bool bIsTrue = true;
            for (int i = 0; i < strInteger.Length; i++)
            {
                if (strInteger[i] < '0' || strInteger[i] > '9')
                {
                    bIsTrue = false;
                }
            }
            return bIsTrue;
        }
    }
}
