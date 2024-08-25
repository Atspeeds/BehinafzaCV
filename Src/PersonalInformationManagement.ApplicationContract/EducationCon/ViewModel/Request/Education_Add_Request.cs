using System;

namespace PersonalInformationManagement.Application.Contract.EducationCon
{
    public class Education_Add_Request
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long ResumeId { get; set; }
    }
}
