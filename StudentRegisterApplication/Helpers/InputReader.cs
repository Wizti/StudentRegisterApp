namespace StudentRegisterApplication.Helpers
{
    internal static class InputReader
    {
        public static string GetString()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) && input.All(char.IsLetter))
                    {
                        return input;
                    }
                    else
                    {
                        Color.Error("Must only contain letters. Try again\n");
                        Color.Magenta("-> ");
                    }
                }
                catch (Exception ex)
                {
                    Color.Error("Must only contain letters. Try again\n");
                    Color.Magenta("-> ");

                }
            }
        }

        public static int GetInt()
        {
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch (Exception ex)
                {
                    Color.Error($"{ex.Message}. Try again\n");
                    Color.Magenta("-> ");

                }
            }
        }
    }
}
