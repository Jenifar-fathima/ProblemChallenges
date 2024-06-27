namespace TwoDimensionalArrayProblem
{
    class TwoDimensionalArray
    {
        public static void Solution()
        {
            int nRow = 2;
            int nCol = 5;
            int[,] lstStudentGrade = new int[nRow,nCol];
            int nAverageGroup1 = 0;
            int nAverageGroup2 = 0;
            for(int i = 0; i < nRow; i++)
            {
                for(int j = 0; j < nCol; j++)
                {
                    _ = int.TryParse(Console.ReadLine(), out lstStudentGrade[i,j]);
                }
            }
            for(int i = 0; i < nCol; i++)
            {
                nAverageGroup1 += lstStudentGrade[0,i];
                nAverageGroup2 += lstStudentGrade[1,i];
            }
            
            Console.WriteLine("Average for Group 1 :{0}\nAverage for Group 2 :{1}", nAverageGroup1/nCol,nAverageGroup2/nCol);
        }
    }
}
