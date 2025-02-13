namespace ClassroomManagement
{
    public class Student : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Classroom Classroom { get; set; }

        public Student(string name, string surname, Classroom classroom) : base()
        {
            Name = name;
            Surname = surname;
            Classroom = classroom;
        }
    }
}
