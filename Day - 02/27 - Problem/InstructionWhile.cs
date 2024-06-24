namespace InstructionWhileProblem
{
    class InstructionWhile
    {
        public static void Solution()
        {
            while (true)
            {
                int nValue = Convert.ToInt32(Console.ReadLine());
                if (nValue == 0)
                {
                    break;
                }
                Console.WriteLine(nValue*10);
            } 
        }
    }
}
