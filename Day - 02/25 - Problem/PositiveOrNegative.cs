namespace PositiveOrNegativeProblem
{
    class PositiveOrNegative
    {
        public static void Solution()
        {
            Console.Write("Enter the Value :");
            int nValue = Convert.ToInt32(Console.ReadLine());

            if( nValue > 0 )
            {
                Console.WriteLine("Positive");
            }
            else if( nValue < 0 )
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("It is neither positive nor negative");
            }
        }
    }
}
