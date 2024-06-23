namespace SquareNumberProblem
{
    class SquareNumber
    {
        public static void Solution()
        {
            int nNumber = Convert.ToInt32(Console.ReadLine());

            int nResult = nNumber*nNumber;
            Console.WriteLine("{0} X {0} = {1}",nNumber, nResult);
        }
    }
}
