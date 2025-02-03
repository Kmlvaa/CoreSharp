using System;
using System.Collections.Generic;
namespace Extension_Virtual
{
    public class Developer : Person
    {
        public int Salary { get; set; }

        public Developer(string name, string surname, int salary) : base(name, surname)
        {
            Salary = salary;
        }

        //cannot override this method because of SEALED
        /*public override sealed string GetInfo()
        {
            return $"{base.GetInfo()} - Salary: {Salary}";
        }*/
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Salary - {Salary}";
        }
    }
}
