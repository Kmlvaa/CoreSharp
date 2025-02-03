using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> list = new MyList<int>();

            //MyList<string> list = new MyList<string>();
            //list.Add("1");
            //list.Add("2");
            //list.Add("3");

            //Console.WriteLine(list[2]);


            //MyList<Student> students = new MyList<Student>();
            //students.Add(new Student("Samira", 100));
            //students.Add(new Student("Konul", 95));

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.Getİnfo());
            //}

            MyList<Developer> devees = new MyList<Developer>(); //IEmployee'den implement edir

            MyList<Car> cars = new MyList<Car>(); //BaseEntity'den miras alir


            #region Generic Function

            Console.WriteLine(GetValue<int>(1));
            Console.WriteLine(GetValue<string>("Hello"));
            Console.WriteLine(GetValue<bool>(true));

            T GetValue<T> (T value) // ilk T qaytardigi tipi gosterir, novbetiler ise parameterin tipini
            {
                return value;
            }

            #endregion
        }
    }
}
