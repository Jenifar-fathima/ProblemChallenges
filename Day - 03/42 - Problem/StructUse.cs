namespace StructUseProblem
{
    class StructUse
    {
        public struct Member
        {
            public string strName;
            public int nAge;
        }
        public static void Solution()
        {
            Member m = new Member();
            m.strName = Console.ReadLine();
            Console.WriteLine("Hello, {0}", m.strName);

        }
    }
}
