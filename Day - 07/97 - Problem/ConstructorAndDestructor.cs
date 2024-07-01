namespace ConstructorAndDestructorProblem
{
    class ConstructorAndDestructor
    {
        public static void Solution()
        
        {
            _ = int.TryParse(Console.ReadLine(), out int nRange);
            Person[] person = new Person[nRange];

            for (int i = 0; i < nRange; i++)
            {
                person[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
        }
        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return $"Hello! my name is {Name}";
            }

            ~Person()
            {
                Name = string.Empty;
            }
        }
    }
}
