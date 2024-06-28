namespace ReturnMainCalculator
{
    class ReturnMain
    {
        public static int Main(string[] args)
        {
            
            if (args.Length != 3)
            {
                Console.WriteLine("Incorrect number of arguments.");
                return 1;
            }

            if (!int.TryParse(args[0], out int num1))
            {
                Console.WriteLine("The first argument is not a valid number.");
                return 3;
            }

            if (!int.TryParse(args[2], out int num2))
            {
                Console.WriteLine("The third argument is not a valid number.");
                return 3;
            }

            char operation = args[1][0];

            if (operation != '+' && operation != '-' && operation != '*' && operation != 'x' && operation != '/')
            {
                Console.WriteLine("Invalid operator.");
                return 2;
            }

            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;

                case '-':
                    Console.WriteLine(num1 - num2);
                    break;

                case '*':
                case 'x': 
                    Console.WriteLine(num1 * num2);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return 3;
                    }
                    Console.WriteLine(num1 / num2);
                    break;
            }

            return 0; 
        }
    }
}
