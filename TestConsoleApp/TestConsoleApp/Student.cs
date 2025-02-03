using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Student: Person
    {
        private protected int grade { get; set; }
        //birinci access mod.(private) diger project ucun kecerlidir
        //ikinci access mod.(protected) ise bu projectler ucun kecerlidir

        public Student()
        {

        }
        public Student(string name, int birthyear, int grade) : base(name, birthyear)
        {
            this.grade = grade;
        }

        public string GetInfo()
        {
            return $"Name: {this.Name}, BirthYear: {this.BirthYear}";
        }
    }
}
