namespace Class_0407_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(143, "名字", 100);
            Console.WriteLine(s1.name.ToString());
            Console.WriteLine(s1.Info());
            Console.WriteLine(s1.StudentInfo());
        }
    }

    class Person
    {
        public string name;
        public int Id;
        public Person()
        {
            name = "預設名字";
        }

        public Person(int id, string name)
        {
            Id = id;
            this.name = name;
        }

        public string Info()
        {
            return "Person 的info";
        }
    }

    class Student : Person
    {
        private int Score;
        public Student(int id, string name, int score) : base(id, name)
        {
            Score = score;
        }

        public int Grade
        {
            get
            {
                return Score;
            }
        }

        public string StudentInfo()
        {
            return "學生的新方法";
        }
        public string Info()
        {
            return "學生類別自己的info";
        }

    }

}