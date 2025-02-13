namespace File
{
    public class Product
    {
        private static int _id;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Product(string name)
        {
            Id = _id++;
            Name = name;
            Code = name.Substring(0, 2).ToUpper() + _id;
        }

    }
}
 