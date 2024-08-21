namespace PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request
{
    public class Resume_GetUserId_Request
    {
        public long UserId { get; set; }

		public Resume_GetUserId_Request(long userId)
		{
			UserId = userId;
		}
	}
}
