using _0_FrameWork.FW.Domain;
using System.Collections.Generic;

namespace PersonalInformationManagement.Domain.ResumeAgg
{
	public class Resume : EntityBase<long>
	{
		public string Summary { get; private set; }
		//Relation
		public long UserId { get; private set; }
		public virtual ICollection<Skill> Skills { get; private set; } = new List<Skill>();
		public virtual ICollection<Education> Educations { get; private set; } = new List<Education>();
		public virtual ICollection<Experience> Experiences { get; private set; } = new List<Experience>();


		public Resume(string summary, long userId)
		{
			Summary = summary;
			UserId = userId;
		}

	}
}
