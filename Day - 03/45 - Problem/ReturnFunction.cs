namespace ReturnFunctionProblem
{
    class ReturnFunction
    {
        public static void Solution()
        {
            Console.Write("Enter the first Number :");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int nNum1);
            Console.Write("Enter the second Number :");
            bool IsNum2 = int.TryParse(Console.ReadLine(), out int nNum2);

            if(IsNum1 && IsNum2)
            {
                Console.WriteLine("Answer is {0}", Sum(nNum1, nNum2));
            }
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
