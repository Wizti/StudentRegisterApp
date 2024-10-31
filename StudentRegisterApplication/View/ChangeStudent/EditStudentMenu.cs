using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.View.ChangeStudent
{
    internal class EditStudentMenu : MenuBase
    {
        private Student _student;
        public EditStudentMenu(AppController controller, Student student) : base(controller)
        {
            this._student = _controller.GetFullStudentByID(student.Id);
        }

        public override void ShowMenu()
        {
            Console.Clear();

            Color.Cyan("\n\t\t\t\t||\t\t Edit Student \t\t ||\n");
            Color.Magenta(new string('-', 115) + "\n");

            StudentHeading.Show();
            PrintObject.Print(_student);

            Color.White("\nWhat would you like to edit? (0) for MainMenu");
            Color.White("\n  1. Firstname");
            Color.White("\n  2. Lastname");
            Color.White("\n  3. Address");

            Color.Magenta("\n-> ");
            HandleInput(InputReader.GetInt());
        }

        public void HandleInput(int input)
        {
            switch (input)
            {
                case 1:
                    ChangeFirstName();
                    break;

                case 2:
                    ChangeLastName();
                    break;

                case 3:
                    ChangeAddress();
                    break;
                case 0:
                    _controller.ChangeMenu(new MainMenu(_controller));
                    break;

                default:
                    break;
            }
        }

        #region ChangeName
        public void ChangeFirstName()
        {
            Color.White("\nnew Firstname");
            Color.Magenta(" -> ");
            _controller.HandleEditStudentMenu(_student, InputReader.GetString(), ChangeValueOptions.FirstName);
        }

        public void ChangeLastName()
        {
            Color.White("\nnew Lastname");
            Color.Magenta(" -> ");
            _controller.HandleEditStudentMenu(_student, InputReader.GetString(), ChangeValueOptions.LastName);
        }
        #endregion

        #region ChangeAddress
        public void ChangeAddress()
        {
            Color.White("\n  1. Street");
            Color.White("\n  2. City");
            Color.White("\n  3. Postalcode");
            Color.Magenta("\n-> ");

            switch (InputReader.GetInt())
            {
                case 1:
                    ChangeStreet();
                    break;

                case 2:
                    ChangeCity();
                    break;

                case 3:
                    ChangePostalCode();
                    break;

                default:
                    break;
            }
        }
        public void ChangeStreet()
        {
            Color.White("\nnew Street ");
            Color.Magenta("-> ");
            _controller.HandleEditStudentMenu(_student, InputReader.GetString(), ChangeValueOptions.Street);
        }

        public void ChangeCity()
        {
            Color.White("\nnew City ");
            Color.Magenta("-> ");
            _controller.HandleEditStudentMenu(_student, InputReader.GetString(), ChangeValueOptions.City);
        }

        public void ChangePostalCode()
        {
            Color.White("\nnew Postalcode ");
            Color.Magenta("-> ");
            _controller.HandleEditStudentMenu(_student, InputReader.GetInt().ToString(), ChangeValueOptions.PostalCode);
        }
        #endregion
    }
}
