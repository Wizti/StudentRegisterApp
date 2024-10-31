using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;

namespace StudentRegisterApplication.View
{
    internal class PrintAllStudentsMenu : MenuBase
    {
        public PrintAllStudentsMenu(AppController controller) : base(controller)
        {
        }

        public override void ShowMenu()
        {
            Console.Clear();

            StudentHeading.Show();
            PrintObject.Print(_controller.GetStudents());

            Color.Magenta(new string('-', 115) + "\n");
            Color.White("Enter to return");
            Color.Magenta("\n-> ");

            Console.ReadLine();

            _controller.ChangeMenu(new MainMenu(_controller));
        }
    }
}
