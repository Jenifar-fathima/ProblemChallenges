namespace ParentClassProblem
{
    class ParentClass
    {
        public static void Solution()
        {
            Person person = new Person();
            person.Greet();
            Console.WriteLine("==================================");
            Student student = new Student();
            student.Greet();
            student.SetAge(18);
            student.Study();
            student.ShowAge();
            Console.WriteLine("==================================");
            Professor professor = new Professor();
            professor.Greet();
            professor.SetAge(18);
            professor.Explain();

        }
    }
    class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello!!");
        }
        public void SetAge(int n)
        {
            n = age;
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("Im explainingZZZ");
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Im studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old. ");
        }
    }
}
