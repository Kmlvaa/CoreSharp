namespace TaskStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome");
            Console.WriteLine("--------------------------------------------");

            List<User> users = new List<User>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Please, enter fullname: ");
                string name = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");

                Console.Write("Please, enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");

                string password;

                while (true)
                {
                    Console.Write("Please, enter password: ");
                    password = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Red;

                    if (User.PasswordChecker(password)) break;
                    else Console.WriteLine("Enter valid password");

                    Console.ResetColor();
                }
                Console.ResetColor();
                
                users.Add(new User(name, email, password));

                if(users.Count == 2) break;
            }

            while (true)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Show all students");
                Console.WriteLine("2.Get Info by ID");
                Console.WriteLine("0.Quit");
                Console.WriteLine("-------------------------------------------");

                Console.Write("Select a command: ");
                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        foreach (User user in users)
                        {
                            user.GetInfo();
                        }
                        break;
                    case 2:
                        Console.Write("Enter an ID to see more details: ");
                        int ID = int.Parse(Console.ReadLine());

                        User.FindUserById(ID, users);
                        break;
                    case 3:
                        break;
                }
            }

        }
    }
}
