namespace DrawRectProblem
{
    class DrawRect
    {
        public static void Solution()
        {
            Console.Write("Enter the value to be drawn :");
            int nValue = Convert.ToInt32(Console.ReadLine());
            int nWidth = 3;
            int nHeight = 5;

            for (int i = 0; i < nHeight; i++)
            {
                for (int j = 0; j < nWidth; j++)
                {
                    Console.Write(nValue);
                }
                Console.Write("\n");
            }
        }
    }
}
