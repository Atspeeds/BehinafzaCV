using System;

namespace PersonalInformationManagement.Application.Contract.EducationCon
{
    public class Education_GetAll_Response
    {
        public long Id { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
