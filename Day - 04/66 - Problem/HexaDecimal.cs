namespace HexaDecimalProblem
{
    class HexaDecimal
    {
        public static void Solution()
        {
            int nNum;
            do
            {
                bool bIsNum = int.TryParse(Console.ReadLine(), out nNum);
                if (nNum != 0)
                {
                    Console.WriteLine("HexaDecimal Value :{0}",Convert.ToString(nNum,16));
                    Console.WriteLine("Binary Value :{0}", Convert.ToString(nNum, 2));
                }
            }while (nNum != 0);
        }
    }
}
