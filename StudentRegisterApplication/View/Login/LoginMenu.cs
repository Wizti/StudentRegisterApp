using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;

namespace StudentRegisterApplication.View.Login
{
    internal class LoginMenu : MenuBase
    {
        public LoginMenu(AppController controller) : base(controller)
        {
            
        }

        public override void ShowMenu()
        {
            Console.Clear();

            Color.Cyan("\t\t\t\t||\t\t Login \t\t ||\n");
            Color.Magenta(new string('-', 115) + "\n");

            Color.White("Enter your login details.\n");

            HandleLogin();

            _controller.ChangeMenu(new MainMenu(_controller));
        }

        public void HandleLogin()
        {
            Color.White("\nUsername: ");
            Color.Magenta(" -> ");
            string userName = InputReader.GetString();

            Color.White("Password: ");
            Color.Magenta(" -> ");
            string password = Console.ReadLine();

            if (!_controller.HandleLogin(userName, password))
            {
                Color.Error($"login or password was wrong. Enter to return -> ");
                Console.ReadLine();
                ShowMenu();
            }
        }
    }
}
