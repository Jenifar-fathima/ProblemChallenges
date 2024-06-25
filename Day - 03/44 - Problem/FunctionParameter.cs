namespace FunctionParameterProblem
{
    class FunctionParameter
    {
        public static void Solution()
        {
            string? strName = Console.ReadLine();
            Greeting(strName);
            Farewell();
        }
        public static void Greeting(string Name)
        {
            Console.WriteLine("Hello {0}",Name);
        }
        public static void Farewell()
        {
            Console.WriteLine("Good Bye!!");
        }
    }
 }
