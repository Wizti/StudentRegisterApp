namespace StudentRegisterApplication.Model
{
    internal class SystemUser
    {
        public int SystemUserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public UserRole UserRole { get; set; }

        public SystemUser()
        {            
        }

        public SystemUser(string userName, string password, UserRole userRole)
        {
            UserName = userName;
            PassWord = password;
            UserRole = userRole;
        }
    }
}
