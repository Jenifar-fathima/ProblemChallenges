namespace CommutativeMatrixProblem
{
    class CommutativeMatrix
    {
        public static void Solution()
        {
            Console.Write("Enter the number of rows in Matrix A:");
            _ = int.TryParse(Console.ReadLine(), out int nRowA);
            Console.Write("Enter the number of columns in Matrix A:");
            _ = int.TryParse(Console.ReadLine(), out int nColA);

            Console.Write("Enter the number of rows in Matrix B:");
            _ = int.TryParse(Console.ReadLine(), out int nRowB);
            Console.Write("Enter the number of columns in Matrix B:");
            _ = int.TryParse(Console.ReadLine(), out int nColB);

            Console.Write("Enter the number of rows in Matrix C:");
            _ = int.TryParse(Console.ReadLine(), out int nRowC);
            Console.Write("Enter the number of columns in Matrix C:");
            _ = int.TryParse(Console.ReadLine(), out int nColC);

            int[,] mMatrixA = new int[nRowA, nColA];
            int[,] mMatrixB = new int[nRowB, nColB];
            int[,] mMatrixC = new int[nRowC, nColC];
            int[,] mMatrixAT = new int[nColA, nRowA];
            int[,] mMatrixBT = new int[nColB, nRowB];
            int[,] mMatrixCT = new int[nColC, nRowC];

            Console.WriteLine("Enter the elements of Matrix A:");
            GetMatrixElement(mMatrixA);

            Console.WriteLine("Enter the elements of Matrix B:");
            GetMatrixElement(mMatrixB);

            Console.WriteLine("Enter the elements of Matrix C:");
            GetMatrixElement(mMatrixC);
            
            Console.WriteLine("Matrix A:");
            PrintMatrix(mMatrixA);

            Console.WriteLine("Matrix B:");
            PrintMatrix(mMatrixB);

            Console.WriteLine("Matrix C:");
            PrintMatrix(mMatrixC);

            Console.WriteLine("Transpose Matrix A:");
            PrintTransposeMatrix(mMatrixA,mMatrixAT);

            Console.WriteLine("Transpose Matrix B:");
            PrintTransposeMatrix(mMatrixB, mMatrixBT);

            Console.WriteLine("Transpose Matrix C:");
            PrintTransposeMatrix(mMatrixC, mMatrixCT);

            int[,] mMatrixBC = MatrixMultiply(mMatrixB, mMatrixC);
            Console.WriteLine("B x C is :");
            PrintMatrix(mMatrixBC);

            int[,] mMatrixABC = MatrixMultiply(mMatrixA, mMatrixBC);
            Console.WriteLine("A X B x C is :");
            PrintMatrix(mMatrixABC);

            int nRow = mMatrixABC.GetLength(0);
            int nCol = mMatrixABC.GetLength(1);

            int[,] mMatrixABCT = new int[nCol, nRow];
            Console.WriteLine("Transpose of A X B x C is :");
            PrintTransposeMatrix(mMatrixABC, mMatrixABCT);

            int[,] mMatrixCBT = MatrixMultiply(mMatrixCT, mMatrixBT);
            Console.WriteLine("C` X  B` is :");
            PrintMatrix(mMatrixBC);

            int[,] mMatrixCBAT = MatrixMultiply(mMatrixCBT, mMatrixAT);
            Console.WriteLine("C` X  B` X A` is :");
            PrintMatrix(mMatrixCBAT);

            if (AreMatricesEqual(mMatrixABCT, mMatrixCBAT))
            {
                Console.WriteLine("Hence, we proved that (ABC)` = C`B`A` ");
            }
            else 
            { 
                Console.WriteLine("Matrices doesnot match each other."); 
            }
        }

        public static void GetMatrixElement(int[,] matrix)
        {
            int nRow = matrix.GetLength(0);
            int nCol = matrix.GetLength(1);

            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    _ = int.TryParse(Console.ReadLine(), out matrix[i, j]);
                }
            }
        }

        public static int[,] MatrixMultiply(int[,] mMatrix1, int[,] mMatrix2)
        {
            int rows1 = mMatrix1.GetLength(0);
            int cols1 = mMatrix1.GetLength(1);
            int rows2 = mMatrix2.GetLength(0);
            int cols2 = mMatrix2.GetLength(1);

            if(cols1 != rows2)
            {
                Console.WriteLine("Matrix dimensions are not compatible for multiplication.");
                return new int[0, 0]; 
            }
            int[,] mResult = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += mMatrix1[i, k] * mMatrix2[k, j];
                    }
                    mResult[i, j] = sum;
                }
            }
            return mResult;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows1 = matrix.GetLength(0);
            int cols1 = matrix.GetLength(1);

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }Console.WriteLine("\n=============================================================================\n");
        }

        public static void PrintTransposeMatrix(int[,] matrix, int[,] transposeMatrix)
        {
            int rows1 = matrix.GetLength(0);
            int cols1 = matrix.GetLength(1);
            for (int i = 0; i < cols1; i++)
            {
                for (int j = 0; j < rows1; j++)
                {
                    transposeMatrix[i, j] = matrix[j, i];
                    Console.Write(transposeMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n=============================================================================\n");
        }

        public static bool AreMatricesEqual(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
