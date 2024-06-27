namespace SumArrayProblem
{
    class SumArray
    {
        public static void Solution()
        {
            string strNumber = Console.ReadLine();
            int nResult = SumArrayMethod(strNumber);
            Console.WriteLine("Sum :{0}", nResult);
        }
        public static int SumArrayMethod(string textNumber)
        {
            int[] NumberArray = new int[textNumber.Length];
            int nSum = 0;
            for (int i = 0; i < textNumber.Length; i++)
            {
                NumberArray[i] = textNumber[i] - '0';
                if ((NumberArray[i] > 0) && (NumberArray[i] <= 9))
                { 
                    nSum += NumberArray[i];
                }
            }
            return nSum;
        }
    }
}
