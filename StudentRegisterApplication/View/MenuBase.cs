using StudentRegisterApplication.Controller;

namespace StudentRegisterApplication.View
{
    internal abstract class MenuBase
    {
        private protected AppController _controller;

        public MenuBase(AppController controller)
        {
            _controller = controller;
        }

        public abstract void ShowMenu();
    }
}
