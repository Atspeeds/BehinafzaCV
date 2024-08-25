namespace PersonalInformationManagement.Application.Contract.ResumeCon
{
    public class Resume_Add_Request
    {
        public long UserId { get; set; }
        public string Summary { get; set; }
    }
}
