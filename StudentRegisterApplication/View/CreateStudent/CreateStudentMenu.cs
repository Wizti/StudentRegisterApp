using StudentRegisterApplication.Controller;
using StudentRegisterApplication.Helpers;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.View.CreateStudent
{
    internal class CreateStudentMenu : MenuBase
    {
        public CreateStudentMenu(AppController controller) : base(controller)
        {
        }

        public override void ShowMenu()
        {
            Console.Clear();

            Color.Cyan("\t\t\t\t||\t\t Create Student \t\t ||\n");
            Color.Magenta(new string('-', 115));

            string firstName, lastName, street, city;
            int postalCode;

            ReadNameAndAddress(out firstName, out lastName, out street, out city, out postalCode);
            List<ProgrammingKnowledge> skills = ReadProgrammingKnowledge();

            _controller.HandleCreateStudentMenu(firstName, lastName, street, city, postalCode, skills);
            _controller.ChangeMenu(new MainMenu(_controller));
        }

        private List<ProgrammingKnowledge> ReadProgrammingKnowledge()
        {
            bool addMorelanguages = true;
            List<ProgrammingKnowledge> skills = new List<ProgrammingKnowledge>();

            while (addMorelanguages)
            {
                Color.White("Programming Languange");
                Color.Magenta(" -> ");
                string programmingLanguage = Console.ReadLine();
                Color.White("Skill level of language (free text)");
                Color.Magenta(" -> ");
                string skillLevel = Console.ReadLine();

                skills.Add(new ProgrammingKnowledge { Language = programmingLanguage, SkillLevel = skillLevel });

                Color.Cyan("\nAdd more languages? y/n\n");
                Color.Magenta(" -> ");

                string yesNo = InputReader.GetString();
                if (yesNo == "n" || yesNo == "N")
                {
                    addMorelanguages = false;
                }
            }

            return skills;
        }

        private void ReadNameAndAddress(out string firstName, out string lastName, out string? street, out string city, out int postalCode)
        {
            Color.White("\nFirstname");
            Color.Magenta(" -> ");
            firstName = InputReader.GetString();
            Color.White("Lastname");
            Color.Magenta(" -> ");
            lastName = InputReader.GetString();
            Color.White("Street");
            Color.Magenta(" -> ");
            street = Console.ReadLine();
            Color.White("City");
            Color.Magenta(" -> ");
            city = InputReader.GetString();
            Color.White("Postalcode");
            Color.Magenta(" -> ");
            postalCode = InputReader.GetInt();
        }
    }
}
