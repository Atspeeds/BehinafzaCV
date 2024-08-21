using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
	public partial class ResumeApplication
	{
		public async Task<bool> AddAsync(Resume_Add_Request request)
		{
			var userId = _authHelper.GetUserId();

			if (userId == 0)
				return await Task.FromResult(false);

			var resume = new Resume(request.Summary, userId);

			await _repository.AddAysenc(resume);
			await _repository.SaveAsync();

			return await Task.FromResult(true);
		}
	}
}
