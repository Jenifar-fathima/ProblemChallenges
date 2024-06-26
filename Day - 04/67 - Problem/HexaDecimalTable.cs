namespace HexaDecimalTableProblem
{
    class HexaDecimalTable
    {
        public static void Solution()
        {
            for(int i = 0; i <= 255; i++)
            {
                if (i < 16)
                {
                    Console.Write(0);
                }
                Console.Write("{0} ", Convert.ToString(i, 16));
                if (i % 16 == 15)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
