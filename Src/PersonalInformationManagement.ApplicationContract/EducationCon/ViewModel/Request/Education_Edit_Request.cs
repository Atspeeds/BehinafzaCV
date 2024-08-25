using System;

namespace PersonalInformationManagement.Application.Contract.EducationCon
{
    public class Education_Edit_Request
    {
        public long Id { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
