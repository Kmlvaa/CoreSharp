namespace CollectionTask.Helper
{
    public static class Colored
    {
        public static void ChangeColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
