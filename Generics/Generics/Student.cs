namespace Generics
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Getİnfo()
        {
            return $"Name: {Name} - Grade: {Grade}";
        }

    }
}
