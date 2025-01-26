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

            while (true)
            {
                while (true)
                {
                    Console.Write("Please select the size: ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50) break;
                    else Console.WriteLine("Size is improper!");
                    Console.WriteLine("-------------------------");
                }

                Console.Write("Please select the color of the shoes: ");
                string? color = Console.ReadLine();

                Console.Write("Please select the category: ");
                string category = Console.ReadLine();

                Console.Write("Please select the count: ");
                int count = int.Parse(Console.ReadLine());

                Console.Write("Please select the price: ");
                decimal price = decimal.Parse(Console.ReadLine());

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
            }

        }
    }
}
