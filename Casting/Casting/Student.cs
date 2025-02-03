namespace Casting
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - {Grade}";
        }
    }
}
