namespace EquivalentProblem
{
    class Equivalent
    {
        public static void Solution()
        {
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            int nNum2 = Convert.ToInt32(Console.ReadLine());
            int nNum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((nNum1 + nNum2) * nNum3);
            Console.WriteLine(nNum1 * nNum3 + nNum2 * nNum3);
        }
    }
}
