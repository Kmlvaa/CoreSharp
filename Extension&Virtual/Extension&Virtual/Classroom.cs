using Extension_Virtual.Exceptions;

namespace Extension_Virtual
{
    public class Classroom
    {
        public int StudentLimit { get; set; }
        public string Title { get; set; }
        public Student[] Students;

        public Classroom(string title, int studentLimit)
        {
            Title = title;
            StudentLimit = studentLimit;
            Students = new Student[0];
        }

        #region Indexer

        public Student this[int index]
        {
            get => Students[index];
            set => Students[index] = value;
        }

        #endregion

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(message: "Student can not be null", null);

            if (Students.Length == StudentLimit)
                throw new StudentLimitException("Student limit has reached");

            Array.Resize(ref Students, Students.Length + 1);

            Students[Students.Length - 1] = student;
        }
    }
}
