using ClassroomManagement.Enum;
using ClassroomManagement.Exceptions;

namespace ClassroomManagement
{
    public class Classroom : BaseClass
    {
        public string Name { get; set; }
        public Student[] Students;
        public ClassType Type { get; set; }
        public int ClassLimit { get; set; }
        public Classroom(string name, ClassType classType) : base()
        {
            Name = name;
            Type = classType;
            Students = new Student[0];
            ClassLimit = classType.Equals("Frontend") ? 15 : 20;
        }
        public void AddStudent(Student student)
        {
            if (student == null) throw new ArgumentNullException("Can not add null");

            if (Students.Length == ClassLimit) throw new ClassroomLimitException("Classroom limit has been reached. Can not add more students.");

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void RemoveStudent(int id)
        {
            var student = Students.FirstOrDefault(x => Id == id);
            if (student is null) throw new StudentNotFoundException("Student not found");

            Student[] students = new Student[0];

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == student) continue;
                else
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = student;
                }
            }

            Students = students;
            Console.WriteLine("Student removed successfully.");
        }
        public void ShowStudentsByClassName(string classname)
        {
            if (!string.IsNullOrEmpty(classname))
            {

            }
        } 
    }
}
