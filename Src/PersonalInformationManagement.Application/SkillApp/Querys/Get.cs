using PersonalInformationManagement.Application.Contract.SkillCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
    public partial class SkillApplication
    {

        public async Task<List<Skill_GetAll_Response>> GetAllAsync(long resumeId)
        {
            return await _skillRepository.GetByResume(resumeId);
        }
    }
}
