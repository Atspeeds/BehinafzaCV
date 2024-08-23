using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.ResumeCon
{
    public interface ISkillApplication
    {
        Task<bool> AddAsync(Skill_Add_Request request);
        Task<List<Skill_GetAll_Response>> GetAllAsync(long resumeId);
    }
}
