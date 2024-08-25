using _0_FrameWork.FW.Infrastrure;
using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra
{
    public class EducationRepository : RepositoryBase<long, Education>, IEducationRepository
    {
        private readonly PersonalInformationContext _context;

        public EducationRepository(PersonalInformationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Education_GetAll_Response>> GetByResumeAsync(long resumeId)
        {
            return await _context.Educations
              .Where(x => x.ResumeId == resumeId)
              .Select(x => new Education_GetAll_Response()
              {
                  Id = x.KeyId,
                  Degree = x.Degree,
                  Institution = x.Institution,
                  StartDate = x.StartDate.GetDayPersian(),
                  EndDate = x.EndDate.GetDayPersian(),
              })
              .AsNoTracking().ToListAsync();
        }

        public async Task<Education_Edit_Request> GetDetailAsync(long id)
        {
            return await _context.Educations
                .Select(x => new Education_Edit_Request()
                {
                    Id = x.KeyId,
                    Degree = x.Degree,
                    Institution = x.Institution,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                })
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Education_GetAll_Response>> SearchAsync(Education_Search_Request request)
        {
            var query = _context.Educations
                .Where(x => x.ResumeId == request.ResumeId)
                .Select(x => new Education_GetAll_Response()
                {
                    Id = x.KeyId,
                    Degree = x.Degree,
                    Institution = x.Institution,
                    StartDate = x.StartDate.GetDayPersian(),
                    EndDate = x.EndDate.GetDayPersian(),
                });

            if (!string.IsNullOrWhiteSpace(request.Institution))
                query = query.Where(x => x.Institution.Contains(request.Institution));

            return query.ToListAsync();

        }

    }
}
