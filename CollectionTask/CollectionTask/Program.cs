namespace CollectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Welcome to Weapon training...");
            Console.WriteLine("--------------------------------------------------");

        WeaponSelection:

            while (true)
            {
                Console.WriteLine("1. Thompson M1A1 || bullet type: Lead");
                Console.WriteLine("2. AK-47 || bullet type: Tracer");
                Console.WriteLine("3. M16 || bullet type: Hunting");
                Console.WriteLine("4. SPAS-12 || bullet type: Slug");
                Console.WriteLine("5. M249 SAW || bullet type: FMJ");
                Console.WriteLine("6. Mossberg 500 || bullet type: Buckshot");
                Console.WriteLine("0. Exit");

                Console.Write("Select a weapon: ");

                if (!int.TryParse(Console.ReadLine(), out int weapon))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    continue;
                }
                if (weapon == 0) break;

                switch (weapon)
                {
                    case 1:
                        Weapon weapon1 = new Weapon("Thompson M1A1", Enum.BulletTypeEnum.Lead, 6);
                        Operations(weapon1);
                        break;
                    case 2:
                        Weapon weapon2 = new Weapon(".AK-47", Enum.BulletTypeEnum.Tracer, 20);
                        Operations(weapon2);
                        break;
                    case 3:
                        Weapon weapon3 = new Weapon("M16", Enum.BulletTypeEnum.Hunting, 36);
                        Operations(weapon3);
                        break;
                    case 4:
                        Weapon weapon4 = new Weapon("SPAS-12", Enum.BulletTypeEnum.Slug, 4);
                        Operations(weapon4);
                        break;
                    case 5:
                        Weapon weapon5 = new Weapon("M249 SAW", Enum.BulletTypeEnum.FMJ, 8);
                        Operations(weapon5);
                        break;
                    case 6:
                        Weapon weapon6 = new Weapon("Mossberg 500", Enum.BulletTypeEnum.Buckshot, 12);
                        Operations(weapon6);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Select correct weapon number.");
                        Console.WriteLine("--------------------------------------------------");
                        Console.ResetColor();
                        break;
                }
            }


        }
        static void Operations(Weapon weapon)
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1.Fire");
                Console.WriteLine("2.Fill");
                Console.WriteLine("3.Pull Trigger");
                Console.WriteLine("0.Exit to main menu");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Select an action: ");

                if (!int.TryParse(Console.ReadLine(), out int action))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ResetColor();
                    continue;
                }

                if (action == 0)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Exciting to main menu...");
                    Console.WriteLine("--------------------------------------------------");
                    Console.Clear();
                    break;
                }
                try
                {
                    switch (action)
                    {
                        case 1:
                            weapon.Fire();
                            break;
                        case 2:
                            weapon.Fill();
                            break;
                        case 3:
                            weapon.PullTrigger();
                            break;
                        case 0:
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice. Please select a valid action.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"An error occured: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }
    }
}
