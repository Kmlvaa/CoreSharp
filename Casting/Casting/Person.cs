namespace Casting
{
    public class Person
    {
        private static int _id = 1;
        public int Id { get; }
        public string Name { get; set; }

        public Person(string name)
        {
            Id = _id++;
            Name = name;
        }

        public virtual string GetInfo()
        {
            return Name;
        }
    }
}
