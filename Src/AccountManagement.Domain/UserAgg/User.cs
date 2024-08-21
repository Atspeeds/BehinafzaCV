using _0_FrameWork.FW.Domain;

namespace AccountManagement.Domain.UserAgg
{
	public class User : EntityBase<long>
	{
		public string FullName { get; private set; }
		public string Mobile { get; private set; }
		public string PasswordHash { get; private set; }


		public User(string fullName, string mobile, string passwordHash)
		{
			FullName = fullName;
			Mobile = mobile;
			PasswordHash = passwordHash;
		}

	}
}
