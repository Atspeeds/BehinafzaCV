namespace PersonalInformationManagement.Application.Contract.ExperienceCon
{
    public class Experience_GetAll_Request
    {
        public long Id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
