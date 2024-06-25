namespace AccessControlProblem
{
    class AccessControl
    {
        public static void Solution()
        {
            int nUserName;
            int nPassword;

            int nAttempts = 0;

            do
            {
                Console.Write("Enter Username :");
                bool IsUserName = int.TryParse(Console.ReadLine(), out nUserName);
                Console.Write("Enter Password :");
                bool IsPassword = int.TryParse(Console.ReadLine(), out nPassword);
                if (nUserName != 12 || nPassword != 1234)
                {
                    Console.WriteLine("Login Failed!!");
                    nAttempts++;
                }
            } while ((nUserName != 12 || nPassword != 1234 ) && nAttempts != 3);
            if(nUserName == 12 && nPassword == 1234)
            {
                Console.WriteLine("Login SuccessFul");
            }
        }
    }
}
