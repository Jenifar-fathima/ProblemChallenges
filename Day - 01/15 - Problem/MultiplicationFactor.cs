namespace MultiplicationFactorProblem
{ 
    class MultiplicationFactor
    {
        public static void Solution()
        {
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            int nNum2 = Convert.ToInt32(Console.ReadLine());
            int nNum3 = Convert.ToInt32(Console.ReadLine());

            int nResult = nNum1*nNum2*nNum3;
            Console.WriteLine("{0} X {1} X {2} = {3}",nNum1,nNum2,nNum3,nResult);
        }
    }
}
