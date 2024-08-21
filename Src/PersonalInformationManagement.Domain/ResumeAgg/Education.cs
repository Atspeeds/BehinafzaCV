using _0_FrameWork.FW.Domain;
using System;

namespace PersonalInformationManagement.Domain.ResumeAgg
{
	public class Education : EntityBase<long>
	{
		public string Degree { get; private set; }
		public string Institution { get; private set; }
		public DateTime StartDate { get; private set; }
		public DateTime EndDate { get; private set; }

		//Relation
		public long ResumeId { get; private set; }
		public virtual Resume Resume { get; private set; }
	}
}
