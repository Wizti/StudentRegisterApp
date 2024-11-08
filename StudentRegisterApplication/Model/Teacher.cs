namespace StudentRegisterApplication.Model
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SystemUser SystemUser { get; set; }

        public Teacher()
        {            
        }
        public Teacher(string firstName, string lastName, SystemUser systemUser)
        {
            FirstName = firstName;
            LastName = lastName;
            SystemUser = systemUser;
        }
    }
}
