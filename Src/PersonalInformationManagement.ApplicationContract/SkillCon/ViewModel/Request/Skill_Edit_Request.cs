namespace PersonalInformationManagement.Application.Contract.SkillCon
{
    public class Skill_Edit_Request
    {
        public long Id { get; set; }
        public string SkillName { get; set; }
        public int Score { get; set; }
    }
}
