using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Data;
using StudentRegisterApplication.Model;
using StudentRegisterApplication.Repository;

namespace StudentRegisterApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppController appController = new AppController(new StudentRepository(), new SystemUserRepository());
            appController.Run();
        }
    }
}
