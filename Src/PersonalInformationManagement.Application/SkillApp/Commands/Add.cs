using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
    public partial class SkillApplication
    {

        public async Task<bool> AddAsync(Skill_Add_Request request)
        {
            var skill = new Skill(request.SkillName, request.Score, request.ResumeId);
            await _skillRepository.AddAysenc(skill);
            await _skillRepository.SaveAsync();
            return await Task.FromResult(true);
        }
    }
}
