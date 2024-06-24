using System.Text.Json.Nodes;

namespace InstructionDoWhileProblem
{
    class InstructionDoWhile
    {
        public static void Solution()
        {
            int nValue;
            do
            {
                bool isTrue = int.TryParse(Console.ReadLine(), out nValue);
                Console.WriteLine(nValue * 10);
            }while (nValue!=0) ;
        }
    }
}
