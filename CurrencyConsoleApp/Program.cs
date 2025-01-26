namespace CurrencyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Welcome to currency rate management system!!!");
            Console.WriteLine("-----------------------------------------------");

            string[] codes = { "USD", "EUR", "AUD", "BYN", "BGN", "AED", "KRW", "CZK", "CNY", "DKK" };
            decimal[] courses = { 1.7000M, 1.7766M, 1.0738M, 0.4868M, 0.9079M, 0.4628M, 0.1188M, 0.0708M, 0.2345M, 0.2381M };

            int idx = 0;

            string cmd1 = "1.Show all currency rates";
            string cmd2 = "2.Show currency rate for specific ID";
            string cmd3 = "3.Calculate the amount for specific currency";
            string cmd4 = "4.Exit";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(cmd1);
            Console.WriteLine(cmd2);
            Console.WriteLine(cmd3);
            Console.WriteLine(cmd4);

            Console.ResetColor();

            Console.WriteLine("-----------------------------------------------");

            bool isRunning = true;

            while (isRunning)
            {
                int command = 1;

                #region command validation
                while (true)
                {
                    Console.Write("Select the commmand ID to continue: ");
                    command = int.Parse(Console.ReadLine());

                    if (command >= 1 && command <= 4)
                        break;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter valid command ID between 1 and 4");
                    Console.ResetColor();

                    Console.WriteLine("-----------------------------------------------");
                }
                #endregion

                switch (command)
                {
                    case 1:
                        #region 1.Show all currency rates

                        Console.WriteLine("Code --- Course");
                        while (idx < courses.Length)
                        {
                            Console.WriteLine($"{codes[idx]} --- {courses[idx]}");
                            idx++;
                        }
                        idx = 0;

                        Console.WriteLine("-----------------------------------------------");
                        break;

                    #endregion

                    case 2:
                        #region 2.Show currency rate for specific ID

                        Console.Write("Enter currency alpha3 code (USD,EUR,AUD): ");
                        string? code = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < codes.Length; i++)
                        {
                            if (codes[i] == code)
                            {
                                found = true;
                                Console.WriteLine($"Code: {code}, Course: {courses[i]}");
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("ERROR!!!");
                            Console.WriteLine("The code you entered does not exist");

                            Console.ResetColor();
                        }

                        Console.WriteLine("-----------------------------------------------");
                        break;

                    #endregion

                    case 3:
                        #region 3.Calculate the amount for specific currency

                        Console.WriteLine("Enter amount you want to convert to AZN: ");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter alpha3 code (USD,EUR,AUD): ");
                        string alpha3Code = Console.ReadLine();

                        #region Alpha3 code validation
                        bool isfound = false;
                        decimal Alpha3Course = 0;
                        decimal totalAmount = 0;

                        for (int i = 0; i < codes.Length; i++)
                        {
                            if (codes[i] == alpha3Code)
                            {
                                isfound = true;
                                Alpha3Course = courses[i];
                                break;
                            }
                        }
                        if (!isfound)
                        {
                            Console.WriteLine("-----------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("ERROR!!!");
                            Console.WriteLine("The alpha3 code does not exist");

                            Console.ResetColor();
                        }
                        else
                        {
                            totalAmount = amount * Alpha3Course;
                            Console.WriteLine($"Total amount by currency: {totalAmount} AZN");
                        }
                        #endregion

                        Console.WriteLine("-----------------------------------------------");
                        break;

                    #endregion

                    case 4:
                        #region Exit

                        Console.WriteLine("See you again ;)");
                        isRunning = false;
                        break;

                    #endregion

                    default:
                        Console.WriteLine("Enter valid command ID between 1 and 4");
                        break;
                }
            }

        }
    }
}
