﻿namespace Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ShoesCenter");
            Console.WriteLine("-------------------------");
            decimal totalProcutsAmount = 0;

            while (true)
            {
                Console.Write("Please select the size: ");
                int size = int.Parse(Console.ReadLine());

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

                if(clientAnswer == "No")
                {
                    Console.WriteLine(totalProcutsAmount);
                    break;
                }
            }

        }
    }
}
