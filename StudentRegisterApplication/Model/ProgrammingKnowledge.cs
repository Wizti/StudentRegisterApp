namespace StudentRegisterApplication.Model
{
    internal class ProgrammingKnowledge
    {
        public int Id { get; set; }
        public string Language { get; set; } = "";
        public string SkillLevel { get; set; } = "";
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public ProgrammingKnowledge() { }
        public ProgrammingKnowledge(string language, string skillLevel)
        {
            Language = language;
            SkillLevel = skillLevel;
        }

        public override string ToString()
        {
            return $"{Language} - {SkillLevel}";
        }
    }
}
