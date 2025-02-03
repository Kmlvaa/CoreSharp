using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Virtual
{
    public class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Id = _id++;
            Name = name;
            Surname = surname;
        }

        public virtual string GetInfo()
        {
            return $"ID - {Id}, Name - {Name}, Surname - {Surname}";
        }
    }
}
