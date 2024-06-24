namespace IfCalculatiionProblem
{
    class IfCalculatiion
    {
        public static void Solution()
        {
            Console.Write("Enter the operand 1 :");
            int nOperand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator :");
            string? strOperator = Console.ReadLine();
            Console.Write("Enter the operand 2 :");
            int nOperand2 = Convert.ToInt32(Console.ReadLine());

            if(strOperator == "+")
            {
                Console.WriteLine("{0} {1} {2} = {3}", nOperand1,strOperator, nOperand2, nOperand1 + nOperand2);
            }
            else if(strOperator == "-")
            {
                Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 - nOperand2);
            }
            else if(strOperator == "*" || strOperator == "X") 
            {
                Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 * nOperand2);
            }
            else if (strOperator == "/")
            {
                Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 / nOperand2);
            }
            else if (strOperator == "mod" || strOperator == "%")
            {
                Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 % nOperand2);
            }
            else
            {
                Console.WriteLine("Invalid Operator!!");
            }
        }
    }
}
