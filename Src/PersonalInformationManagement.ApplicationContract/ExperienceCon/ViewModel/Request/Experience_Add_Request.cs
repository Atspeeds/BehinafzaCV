using System;

namespace PersonalInformationManagement.Application.Contract.ExperienceCon
{
    public class Experience_Add_Request
    {
        public long ResumeId { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
