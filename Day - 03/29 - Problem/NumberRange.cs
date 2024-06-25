namespace NumberRangeProblem
{
    class NumberRange
    {
        public static void Solution()
        {
            bool IsInitNum = int.TryParse(Console.ReadLine(), out int nInitValue);
            bool IsRangeNum = int.TryParse(Console.ReadLine(), out int nRangeValue);

            if(IsInitNum && IsRangeNum)
            {
                for(int i = nInitValue; i <= nRangeValue; i++)
                {
                    Console.Write("{0} ",i);
                }
            }
        }
        
    }
}
