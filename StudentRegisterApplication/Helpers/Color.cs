namespace StudentRegisterApplication.Helpers
{
    public static class Color
    {
        private static ConsoleColor _baseColor = ConsoleColor.Green;

        public static void Green(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ForegroundColor = _baseColor;
        }

        public static void Yellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ForegroundColor = _baseColor;
        }

        public static void Cyan(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(text);
            Console.ForegroundColor = _baseColor;
        }

        public static void Magenta(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(text);
            Console.ForegroundColor = _baseColor;
        }
        public static void White(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
            Console.ForegroundColor = _baseColor;
        }

        public static void Error(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = _baseColor;
        }
    }
}
