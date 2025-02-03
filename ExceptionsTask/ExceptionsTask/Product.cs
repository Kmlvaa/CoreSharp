namespace ExceptionsTask
{
    public abstract class Product
    {
        private static int _id; //static olmalidirki, her defe object yaradilanda oncekiler yaddasda saxlanilsin
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; } = 1;

        public static decimal TotalIncome;
        public Product( string name, decimal price)
        {
            Id = ++_id;
            Name = name;
            Price = price;
        }
        public abstract void Sell<T>(T product);
        public abstract string ShowInfo();
    }
}

