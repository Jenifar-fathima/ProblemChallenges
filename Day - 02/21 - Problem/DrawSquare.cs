namespace DrawSquareProblem
{
    class DrawSquare
    {
        public static void Solution()
        {
            Console.Write("Enter the value to be drawn :");
            int nValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width value :");
            int nWidth = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nWidth; i++)
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
