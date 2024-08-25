namespace PersonalInformationManagement.Application.Contract.SkillCon
{
    public class Skill_Add_Request
    {
        public string SkillName { get; set; }
        public int Score { get; set; }
        public long ResumeId { get; set; }
    }
}
