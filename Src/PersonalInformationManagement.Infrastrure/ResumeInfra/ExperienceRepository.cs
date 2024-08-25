using _0_FrameWork.FW.Infrastrure;
using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra
{
    public class ExperienceRepository : RepositoryBase<long, Experience>, IExperienceRepository
    {
        private readonly PersonalInformationContext _context;

        public ExperienceRepository(PersonalInformationContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Experience_GetAll_Request>> GetByResumeAsync(long resumeId)
        {
            return await _context.Experiences
               .Where(x => x.ResumeId == resumeId)
               .Select(x => new Experience_GetAll_Request()
               {
                   Id = x.KeyId,
                   JobTitle=x.JobTitle,
                   Company=x.Company,
                   StartDate=x.StartDate.GetDayPersian(),
                   EndDate=x.EndDate.GetDayPersian(),
               })
               .AsNoTracking().ToListAsync();
        }

        public Task<Experience_Edit_Request> GetDetailAsync(long id)
        {
            return _context.Experiences
                .Select(x => new Experience_Edit_Request()
                {
                    Id = x.KeyId,
                    JobTitle = x.JobTitle,
                    Company = x.Company,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                })
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Experience_GetAll_Request>> SearchAsync(Experience_Search_Request request)
        {
            var query = _context.Experiences
           .Where(x => x.ResumeId == request.ResumeId)
               .Select(x => new Experience_GetAll_Request()
               {
                   Id = x.KeyId,
                   JobTitle = x.JobTitle,
                   Company = x.Company,
                   StartDate = x.StartDate.GetDayPersian(),
                   EndDate = x.EndDate.GetDayPersian(),
               });


            if (!string.IsNullOrWhiteSpace(request.Company))
                query = query.Where(x => x.Company.Contains(request.Company));

            return query.AsNoTracking().ToListAsync();
        }

    }
}
