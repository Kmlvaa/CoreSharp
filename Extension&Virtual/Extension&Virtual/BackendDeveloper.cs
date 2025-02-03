namespace Extension_Virtual
{
    public class BackendDeveloper : Developer
    {
        public string Level { get; set; }

        public BackendDeveloper(string name, string surname, int salary, string level) : base(name, surname, salary)
        {
            Level = level;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - Level: {Level}";
        }
    }
}
