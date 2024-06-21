namespace BasicCalculationProblem
{
    class BasicCalculation
    {
        public static void Solution()
        {
            int nNum1 = Convert.ToInt32(Console.ReadLine());
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nNum1} + {nNum2} = {nNum1 + nNum2}");
            Console.WriteLine($"{nNum1} - {nNum2} = {nNum1 - nNum2}");
            Console.WriteLine($"{nNum1} * {nNum2} = {nNum1 * nNum2}");
            Console.WriteLine($"{nNum1} / {nNum2} = {nNum1 / nNum2}");
            Console.WriteLine($"{nNum1} mod {nNum2} = {nNum1 % nNum2}");
        }
    }
}
