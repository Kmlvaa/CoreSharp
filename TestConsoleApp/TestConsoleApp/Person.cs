using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Person()
        {

        }
        public Person(string name, int birthyear)
        {
            Name = name;
            BirthYear = birthyear;
        }
    }
}
