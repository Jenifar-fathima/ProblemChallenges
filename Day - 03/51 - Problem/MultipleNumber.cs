namespace MultipleNumberProblem
{
    class MultipleNumber
    {
        public static void Solution()
        {
            for(int i=1; i<=500; i++) 
            {
                if(i%3  == 0 && i%5 == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
