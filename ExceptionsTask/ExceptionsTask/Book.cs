using ExceptionsTask.Exceptions;

namespace ExceptionsTask
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; } 

        public Book(string name, decimal price,string authorName, int pageCount) : base(name, price)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override string ShowInfo()
        {
            return $"ID: {base.Id} |Name: {base.Name} | AuthorName: {AuthorName} | PageCount: {PageCount} | Price: {base.Price} | Count: {base.Count}";
        }

        public override void Sell<Book>(Book product)
        {
            if(Count == 0)
            {
                throw new ProductCountisZeroException("No product has left in stock!");
            }

            base.Count--;
            TotalIncome += Price;

            Console.WriteLine($"1 Book sold || Total Income: {TotalIncome}");
        }
    }
}
