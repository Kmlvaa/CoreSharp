using ExceptionsTask.Exceptions;

namespace ExceptionsTask
{
    public class Stock
    {
        private static List<Product> Products;
        public int CapacityLimit { get; set; }

        public Stock(int capacityLimit)
        {
            CapacityLimit = capacityLimit;
            Products = new List<Product> { };
        }

        public void AddProduct(Product product)
        {
            if (Products.Count == CapacityLimit)
                throw new CapacityLimitException("Stock capacity has been reached!");

            Products.Add(product);

            //Array.Resize(ref Products, Products.Count + 1);

            //Products[Products.Count - 1] = product;
        }

        public void GetBookById(int? id)
        {
            if(id == null) throw new ArgumentNullException("ID can not be null");
            Product product = null;

            for(int i = 0; i < Products.Count; i++)
            {
                if(Products[i].Id == id)
                    product = Products[i];
            }

            if (product is null)
                throw new NotFoundException("Product not found");
            else Console.WriteLine(product.ShowInfo());
        }
        public List<Product> GetAllBooks()
        {
            return Products.ToList();
        }

        public Product RemoveById(int id)
        {
            if (id is 0)
                throw new NullReferenceException("ID can not be null");

            Product product = Products.Find(x => x.Id == id);
            Products.Remove(product);

            if (product is null)
                throw new NotFoundException("Product not found");
            else return product;
        }
    }
}
