using StudentRegisterApplication.Helpers;
using StudentRegisterApplication.Model;
using StudentRegisterApplication.Repository;
using StudentRegisterApplication.View;
using StudentRegisterApplication.View.Login;

namespace StudentRegisterApplication.Controller
{
    internal class AppController
    {
        private MenuBase _menu;
        private readonly StudentRepository _studentRepository;

        public AppController(StudentRepository studentRepository)
        {
            _menu = new MainMenu(this);
            _studentRepository = studentRepository;
        }

        public void Run()
        {
            if (!_studentRepository.IsAnyLoggedIn())
            {
                _menu = new LoginMenu(this);
                _menu.ShowMenu();
            }
            _menu.ShowMenu();
        }

        public void ChangeMenu(MenuBase menu)
        {
            _menu = menu;
            Run();
        }

        public bool HandleLogin(string username, string password)
        {
            SystemUser user = _studentRepository.GetAllSystemUsers().Where(u => u.UserName == username).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            if (user.PassWord == password)
            {
                user.LoggedIn = true;
                _studentRepository.Update(user);
            }
            return true;
        }

        public void HandleCreateStudentMenu(string firstName, string lastName, string street, string city, int postalCode, List<ProgrammingKnowledge> skills)
        {
            _studentRepository.Create(new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = new Address(street, city, postalCode),
                ProgrammingKnowledge = skills
            });
        }

        public void HandleEditStudentMenu(Student student, string value, ChangeValueOptions options)
        {
            switch (options)
            {
                case ChangeValueOptions.FirstName:
                    student.FirstName = value;
                    break;
                case ChangeValueOptions.LastName:
                    student.LastName = value;
                    break;
                case ChangeValueOptions.Street:
                    student.Address.Street = value;
                    break;
                case ChangeValueOptions.City:
                    student.Address.City = value;
                    break;
                case ChangeValueOptions.PostalCode:
                    student.Address.PostalCode = int.Parse(value);
                    break;
                default:
                    break;
            }
            _studentRepository.Edit(student);
        }

        public Student HandleSearchInputByInt(int searchPhrase)
        {
            return _studentRepository.GetById(searchPhrase);
        }

        public List<Student> HandleSearchInputByString(string searchPhrase)
        {
            return _studentRepository.GetByPhrase(searchPhrase);
        }

        public bool HandleDeleteStudentMenu(int id)
        {
            if (_studentRepository.GetById(id) != null)
            {
                _studentRepository.Delete(_studentRepository.GetById(id));
                return true;
            }
            return false;
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetFullStudentByID(int id)
        {
            return _studentRepository.GetFullById(id);
        }

        public SystemUser GetLoggedInSystemUser()
        {
            return _studentRepository.GetSystemUser();
        }

        public void Quit()
        {
            var users = _studentRepository.GetAllSystemUsers().Where(l => l.LoggedIn);

            foreach (var user in users)
            {
                user.LoggedIn = false;
                _studentRepository.Update(user);
            }
        }
    }
}
