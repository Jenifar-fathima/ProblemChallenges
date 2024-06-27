namespace TwoDimensionalCharProblem
{
    class TwoDimensionalChar
    {
        public static void Solution()
        {
            int nRow = 20;
            int nCol = 70;
            char[,] lstArr = new char[nRow,nCol];
            char cLetter = 'X';
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    lstArr[i, j] = cLetter;
                    Console.Write(lstArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
