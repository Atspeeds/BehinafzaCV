namespace PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response
{
	public class Resume_GetAll_Response
	{
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Summary { get; set; }
        public string DateCreation { get; set; }
    }
}
