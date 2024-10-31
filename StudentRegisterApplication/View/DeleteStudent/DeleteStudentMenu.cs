using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;

namespace StudentRegisterApplication.View.DeleteStudent
{
    internal class DeleteStudentMenu : MenuBase
    {
        public DeleteStudentMenu(AppController controller) : base(controller)
        {
        }

        public override void ShowMenu()
        {
            Console.Clear();

            Color.Cyan("\t\t\t\t||\t\t Delete Student \t\t ||\n");
            Color.Magenta(new string('-', 115) + "\n");

            StudentHeading.Show();
            PrintObject.Print(_controller.GetStudents());

            Color.White("\nEnter ID to delete or (0) for MainMenu)");
            Color.Magenta("\n-> ");

            int input = InputReader.GetInt();
            if (input == 0)
            {
                _controller.ChangeMenu(new MainMenu(_controller));
            }
            else if (_controller.HandleDeleteStudentMenu(input))
            {
                Color.White("Delete success. Enter to return");
                Color.Magenta("\n-> ");
                Console.ReadLine();
            }
            else
            {
                Color.Error("Could not find user with that Id. Enter to return -> ");
                Console.ReadLine();
            }

            _controller.ChangeMenu(new MainMenu(_controller));
        }
    }
}
