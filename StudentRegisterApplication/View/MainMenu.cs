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
                    HandleCreateAccess();
                    break;

                case "2":
                    HandleEditAccess();
                    break;

                case "3":
                    HandleDeleteAccess();
                    break;

                case "4":
                    _controller.ChangeMenu(new PrintAllStudentsMenu(_controller));
                    break;

                case "5":
                    Quit();                  
                    break;

                default:
                    ShowMenu();
                    break;
            }
        }

        public void HandleCreateAccess()
        {
            if(_controller.GetLoggedInSystemUser().UserRole.AddRemove)
            {
                _controller.ChangeMenu(new CreateStudentMenu(_controller));
            }
            else
            {
                Color.Error("You dont have access to create new student. Enter to return ->");
                Console.ReadLine();
                ShowMenu();
            }
        }

        public void HandleDeleteAccess()
        {
            if(_controller.GetLoggedInSystemUser().UserRole.AddRemove)
            {
                _controller.ChangeMenu(new DeleteStudentMenu(_controller));
            }
            else
            {
                Color.Error("You dont have access to delete student. Enter to return ->");
                Console.ReadLine();
                ShowMenu();
            }
        }

        public void HandleEditAccess()
        {
            if (_controller.GetLoggedInSystemUser().UserRole.Edit)
            {
                _controller.ChangeMenu(new SearchStudentMenu(_controller));
            }
            else
            {
                Color.Error("You dont have access to edit student. Enter to return ->");
                Console.ReadLine();
                _controller.ChangeMenu(new MainMenu(_controller));
            }
        }

        public void Quit()
        {
            _controller.Quit();
            Console.WriteLine("\nGoodbye, have a nice day!");
            Environment.Exit(0);
        }

    }
}
