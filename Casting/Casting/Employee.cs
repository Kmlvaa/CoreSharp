namespace Casting
{
    public class Employee : Person
    {
        public int Salary { get; set; }

        public Employee(string name, int salary): base(name)
        {
            Salary = salary;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - {Salary}";
        }
    }
}
