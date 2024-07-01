//Calculate n!
namespace FactorialProblem
{
    class Factorial
    {
        public static void Solution()
        { 
            Console.Write("Enter the number to calculate factorial :");
            _=int.TryParse(Console.ReadLine(), out int nNumber);

            int nResult = FactorialMethod(nNumber);
            Console.WriteLine(nResult);
        }
        public static int FactorialMethod(int nNumber)
        {
            if(nNumber == 0 || nNumber == 1) 
                return 1;
            else
            {
                return nNumber * FactorialMethod(nNumber - 1);
            }
        }
    }
}
