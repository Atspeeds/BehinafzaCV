﻿using _0_FrameWork.FW.Domain;
using System;

namespace PersonalInformationManagement.Domain.ResumeAgg
{
	public class Experience : EntityBase<long>
	{
		public string JobTitle { get; private set; }
		public string Company { get; private set; }
		public DateTime StartDate { get; private set; }
		public DateTime EndDate { get; private set; }

		//Relation
		public long ResumeId { get; private set; }
		public virtual Resume Resume { get; private set; }

        public Experience(string jobTitle, string company, DateTime startDate, DateTime endDate, long resumeId)
        {
            JobTitle = jobTitle;
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
            ResumeId = resumeId;
        }

        public void Edit(string jobTitle, string company, DateTime startDate, DateTime endDate)
        {
            JobTitle = jobTitle;
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
        }


    }
}
