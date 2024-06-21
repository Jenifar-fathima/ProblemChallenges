namespace ReverseOrderProblem
{
    class ReverseOrder
    {
        public static void Solution()
        {
            char charAlphabet1 = Convert.ToChar(Console.ReadLine());
            char charAlphabet2 = Convert.ToChar(Console.ReadLine());
            char charAlphabet3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{2} {1} {0}", charAlphabet1, charAlphabet2, charAlphabet3);
        }
    }
}
