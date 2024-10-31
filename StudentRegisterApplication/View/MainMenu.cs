using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;
using StudentRegisterApplication.View.ChangeStudent;
using StudentRegisterApplication.View.CreateStudent;
using StudentRegisterApplication.View.DeleteStudent;

namespace StudentRegisterApplication.View
{
    internal class MainMenu : MenuBase
    {
        public MainMenu(AppController controller) : base(controller)
        {
        }

        public override void ShowMenu()
        {
            Console.Clear();
            Color.Cyan("\t\t\t\t||\t\t Student Manager 1.0\t\t ||\n");
            Color.Magenta(new string('-', 115));           
            Color.White("\n  1. Create new\n");
            Color.White("  2. Edit existing\n");
            Color.White("  3. Delete\n");
            Color.White("  4. Print all\n");
            Color.White("  5. Quit\n");
            Color.Magenta(new string('-', 115));
            Color.Magenta("\n-> ");

            HandleInput();
        }

        private void HandleInput()
        {
            switch ((InputReader.GetInt().ToString()))
            {
                case "1":
                    _controller.ChangeMenu(new CreateStudentMenu(_controller));
                    break;

                case "2":
                    _controller.ChangeMenu(new SearchStudentMenu(_controller));
                    break;

                case "3":
                    _controller.ChangeMenu(new DeleteStudentMenu(_controller));
                    break;

                case "4":
                    _controller.ChangeMenu(new PrintAllStudentsMenu(_controller));
                    break;

                case "5":
                    Quit();                  
                    break;

                default:
                    break;
            }
        }
        public void Quit()
        {
            Console.WriteLine("\nGoodbye, have a nice day!");
            Environment.Exit(0);
        }

    }
}
