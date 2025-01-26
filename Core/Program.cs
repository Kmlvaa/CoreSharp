namespace Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ShoesCenter");
            Console.WriteLine("-------------------------");
            decimal totalProcutsAmount = 0;
            int size = 0;

            int[] sizes = new int[3];
            int[] counts = new int[3];
            string[] colors = new string[3];
            decimal[] prices = new decimal[3];
            string[] categories = new string[3];

            int idx = 0;

            while (true)
            {
                #region size validation
                while (true)
                {
                    Console.Write("Please select the size: ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                    {
                        sizes[idx] = size;
                        break;
                    }
                    else Console.WriteLine("Size is improper!");
                    Console.WriteLine("-------------------------");
                }
                #endregion

                Console.Write("Please select the color of the shoes: ");
                string? color = Console.ReadLine();

                if (color != null)
                {
                    colors[idx] = color;
                }

                Console.Write("Please select the category: ");
                string category = Console.ReadLine();

                if (category != null)
                {
                    categories[idx] = category;
                }

                Console.Write("Please select the count: ");
                int count = int.Parse(Console.ReadLine());
                if (count >= 0)
                {
                    counts[idx] = count;
                }

                Console.Write("Please select the price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                if (price >= 0)
                {
                    prices[idx] = price;
                }

                decimal totalAmount = count * price;

                Console.WriteLine($"size: {size}, color: {color}, category: {category}, totalAmount: {totalAmount}");

                Console.Write("Do you want to add new shoes? Yes/No :  ");
                string clientAnswer = Console.ReadLine();

                totalProcutsAmount += totalAmount;

                if (clientAnswer == "No")
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Total amount: {totalProcutsAmount}");
                    break;
                }
                idx++;

            }
            while (idx>=0)
            {
                Console.WriteLine($" {idx} Operator details: size={sizes[idx]}, count={counts[idx]}, price={prices[idx]}");
                idx--;
            }

        }
    }
}
