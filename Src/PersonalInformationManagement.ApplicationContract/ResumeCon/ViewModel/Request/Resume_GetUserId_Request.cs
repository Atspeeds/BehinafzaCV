namespace PersonalInformationManagement.Application.Contract.ResumeCon
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
