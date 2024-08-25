using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.SkillCon
{
    public interface ISkillApplication
    {
        Task<bool> AddAsync(Skill_Add_Request request);
        Task<List<Skill_GetAll_Response>> GetAllAsync(long resumeId);
        Task<bool> EditAsync(Skill_Edit_Request request);
        Task<Skill_Edit_Request> GetDetailAsync(long id);
    }
}
