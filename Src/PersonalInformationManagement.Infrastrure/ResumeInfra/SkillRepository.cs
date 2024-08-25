using _0_FrameWork.FW.Infrastrure;
using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra
{
    public class SkillRepository : RepositoryBase<long, Skill>, ISkillRepository
    {
        private readonly PersonalInformationContext _context;
        public SkillRepository(PersonalInformationContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Skill_GetAll_Response>> GetByResume(long resumeId)
        {
            return await _context.Skills
                .Where(x => x.ResumeId == resumeId)
                .Select(x => new Skill_GetAll_Response()
                {
                    Score = x.Score,
                    SkillName = x.SkillName,
                }).AsNoTracking().ToListAsync();
        }
    }
}
