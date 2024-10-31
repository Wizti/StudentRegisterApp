namespace StudentRegisterApplication.Helpers
{
    internal class StudentHeading
    {
        public static void Show()
        {
            Color.Cyan(string.Format("{0, -7}{1, -12}{2, -12}{3, -37}{4, -12}", "ID", "Firstname", "Lastname", "Address", "Skills") + "\n");
            Color.Magenta(new string('-', 115) + "\n");
        }
    }
}
