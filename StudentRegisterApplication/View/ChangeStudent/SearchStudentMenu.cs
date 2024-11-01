using Microsoft.IdentityModel.Tokens;
using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.View.ChangeStudent
{
    internal class SearchStudentMenu : MenuBase
    {
        public SearchStudentMenu(AppController controller) : base(controller)
        {
        }

        public override void ShowMenu()
        {
            Console.Clear();

            Color.Cyan("\t\t\t\t||\t\t Search Student \t\t ||\n");
            Color.Magenta(new string('-', 115) + "\n");

            Color.White("Enter id, firstname, lastname, city, street or programminglanguage to search.. (M) MainMenu \n");
            Color.Magenta("-> ");

            HandleInput(Console.ReadLine());

            _controller.ChangeMenu(new MainMenu(_controller));
        }

        private void HandleInput(string input)
        {
            if (input == "m" || input == "M")
            {
                _controller.ChangeMenu(new MainMenu(_controller));
                return;
            }

            IfNullorNothing(input);
            IfDigit(input);
            Ifstring(input);
            
        }
        #region InputOutcomes
        private void IfDigit(string input)
        {
            if (input.All(char.IsDigit))
            {
                Student student = _controller.HandleSearchInputByInt(int.Parse(input));

                if (student != null)
                {
                    _controller.ChangeMenu(new EditStudentMenu(_controller, student));
                }
                else
                {
                    Color.Error($"Could not find user with Id: {input}. Enter to return -> ");
                    Console.ReadLine();
                    _controller.ChangeMenu(new SearchStudentMenu(_controller));
                }
                return;
            }
        }

        private void Ifstring(string input)
        {
            List<Student> searchResult = _controller.HandleSearchInputByString(input);

            if (searchResult.Count == 1)
            {
                _controller.ChangeMenu(new EditStudentMenu(_controller, searchResult.First()));
                
            }
            else if (searchResult.Count > 1)
            {
                ShowListOfStudentsSearch(searchResult);
            }
            else
            {
                Color.Error($"Could not find any user that matches: {input}. Enter to return -> ");
                Console.ReadLine();
                _controller.ChangeMenu(new SearchStudentMenu(_controller));
            }
            return;
        }

        private void IfNullorNothing(string input)
        {
            if (input.IsNullOrEmpty())
            {
                Color.Error("Cannot search nothing... Enter to continue");
                Console.ReadLine();
                _controller.ChangeMenu(new SearchStudentMenu(_controller));
            }
        }
        #endregion

        public void ShowListOfStudentsSearch(List<Student> students)
        {
            Console.Clear();

            StudentHeading.Show();
            PrintObject.Print(students);

            Color.White("\nEnter ID of student you want to edit. (0) for Mainmenu");
            Color.Magenta("\n-> ");

            int input = InputReader.GetInt();
            if(input == 0) { _controller.ChangeMenu(new MainMenu(_controller)); }

            Student student = _controller.HandleSearchInputByInt(input);

            if (student != null)
            {
                _controller.ChangeMenu(new EditStudentMenu(_controller, student));
            }
            else
            {
                Color.Error($"Could not find user with that Id. Enter to continue");
                Console.ReadLine();
                ShowListOfStudentsSearch(students);
            }
        }
    }
}
