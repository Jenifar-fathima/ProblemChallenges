namespace InheritenceProblem
{
    class Inheritence
    {
        public static void Solution()
        {
            _=int.TryParse(Console.ReadLine(), out int nRange);
            Person[] person = new Person[nRange];

            for (int i = 0; i < nRange; i++)
            {
                if (i == 0)
                {
                    person[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    person[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < nRange; i++)
            {
                if (i == 0)
                {
                    ((Teacher)person[i]).Explain();

                }
                else
                {
                    ((Student)person[i]).Study();
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("{0} IS STUDYING",Name);
        }
    }
    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("The teacher is explaining");
        }
    }
}
