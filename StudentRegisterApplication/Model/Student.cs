namespace StudentRegisterApplication.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public Address? Address { get; set; }
        public List<ProgrammingKnowledge> ProgrammingKnowledge { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, Address address, List<ProgrammingKnowledge> programmingKnowledge)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ProgrammingKnowledge = programmingKnowledge;
        }

        public override string ToString()
        {         
            if (ProgrammingKnowledge == null || Address == null)
            {
                return string.Format("{0, -7}{1, -12}{2, -12}{3, -37}{4, -12}", Id, FirstName, LastName, "-", "-");
            }

            string skills = string.Empty;
            int counter = 0;

            foreach (var skill in ProgrammingKnowledge)
            {
                if (ProgrammingKnowledge.Count == 1)
                {
                    skills += skill + ".";
                }
                else if (ProgrammingKnowledge.Count > counter)
                {
                    skills += skill + " | ";
                }
                counter++;
            }

            return string.Format("{0, -7}{1, -12}{2, -12}{3, -37}{4, -12}", Id, FirstName, LastName,
            Address, skills);
        }

    }
}
