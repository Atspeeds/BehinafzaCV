using _0_FrameWork.FW.Domain;

namespace PersonalInformationManagement.Domain.ResumeAgg
{
	public class Skill : EntityBase<long>
	{
		public string SkillName { get; private set; }
		public int Score { get; private set; }

		//Relation
		public long ResumeId { get; private set; }
		public virtual Resume Resume { get; private set; }

	}
}
