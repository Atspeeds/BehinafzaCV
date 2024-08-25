using System;

namespace PersonalInformationManagement.Application.Contract.ExperienceCon
{
    public class Experience_Edit_Request
    {
        public long Id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
