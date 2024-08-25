using _0_FrameWork.FW.Infrastrure;
using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Application.Contract.ResumeCon;
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

        public async Task<bool> DeleteAllResumeAsync(long id)
        {
            var resume = await _context.Resumes
                  .Include(r => r.Skills)
                  .Include(r => r.Educations)
                  .Include(r => r.Experiences)
                  .SingleOrDefaultAsync(r => r.KeyId == id);

            _context.Skills.RemoveRange(resume.Skills);
            _context.Educations.RemoveRange(resume.Educations);
            _context.Experiences.RemoveRange(resume.Experiences);

            _context.Resumes.Remove(resume);

            await _context.SaveChangesAsync();

            return await Task.FromResult(true);
        }

        public async Task<List<Resume_GetAll_Response>> GetAllAsync(long userId)
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

        public Task<Resume_Edit_Request> GetDetailAsync(long id)
        {
            return _context.Resumes
                .Select(x => new Resume_Edit_Request()
                {
                    Id = x.KeyId,
                    Summary = x.Summary,
                })
                .FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
