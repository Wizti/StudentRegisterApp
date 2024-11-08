using StudentRegisterApplication.Helpers;

namespace StudentRegisterApplication.Model
{
    internal class UserRole
    {
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }
        public bool AddRemove { get; set; }
        public bool Edit { get; set; }
        public bool SetGrade { get; set; }

        public UserRole()
        {            
        }

        public UserRole(string roleName, bool addRemove, bool edit, bool setGrade)
        {
            RoleName = roleName;
            AddRemove = addRemove;
            Edit = edit;
            SetGrade = setGrade;
        }
    }
}
