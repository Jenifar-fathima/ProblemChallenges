namespace RandomNumberProblem
{
    class RandomNumber
    {
        public static void Solution()
        {
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            int nNum2 = Convert.ToInt32(Console.ReadLine());
            Random randomNum = new Random();
            int nResultNum = randomNum.Next(nNum1+1,nNum2-1);

            Console.WriteLine(nResultNum);
        }
    }
}
