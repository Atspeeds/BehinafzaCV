using _0_FrameWork.FW.Domain;
using PersonalInformationManagement.Application.Contract.SkillCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Domain.ResumeAgg.RepositoryService
{
    public interface ISkillRepository:IRepositoryBase<long,Skill>
    {
        Task<List<Skill_GetAll_Response>> GetByResume(long resumeId);
        Task<Skill_Edit_Request> GetDetailAsync(long id);
    }
}
