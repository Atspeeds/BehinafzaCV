using _0_FrameWork.FW.Infrastrure;
using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra
{
    public class ResumeRepository : RepositoryBase<long, Resume>, IResumeRepository
	{
		private readonly PersonalInformationContext _context;

		public ResumeRepository(PersonalInformationContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}

		public async Task<List<Resume_GetAll_Response>> GetByAsync(long userId)
		{
			return await _context.Resumes.Select(x =>
			new Resume_GetAll_Response
			{
				Id = x.KeyId,
				UserId = x.UserId,
				Summary = x.Summary,
				DateCreation = x.CreationDate.GetDayPersian()
			})
			.Where(x => x.UserId == userId)
			.ToListAsync();
		}
	}
}
