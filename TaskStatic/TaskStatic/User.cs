namespace TaskStatic
{
    class User
    {
        private static int id = 0;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            id++;
            Id = id;
        }
        public User(string name, string email, string password)
        {
            id++;
            Id = id;
            Fullname = name;
            Email = email;
            Password = password;
        }
        public static bool PasswordChecker(string password)
        {
            int UpperIdx = 0;
            int LowerIdx = 0;
            int IntegerIdx = 0;

            char[] Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] Lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int[] Integers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];

            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Upper.Contains(password[i]))
                    {
                        UpperIdx++;
                    }
                    else if (Lower.Contains(password[i]))
                    {
                        LowerIdx++;
                    }
                    else if (Integers.Contains(password[i])) { IntegerIdx++; }
                }
                if (UpperIdx >= 1 && LowerIdx >= 1 && IntegerIdx >= 1)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Id} || {Fullname} || {Email}");
        }
        public static void FindUserById(int id, List<User> users)
        {
            bool isFound = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    isFound = true;
                    Console.WriteLine($"{users[i].Id} || {users[i].Fullname}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            if (!isFound) Console.WriteLine("No user found");
            Console.ResetColor();
        }
    }
}
