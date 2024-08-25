using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.SkillApp
{
    public partial class SkillApplication
    {
        public async Task<bool> EditAsync(Skill_Edit_Request request)
        {
            var skill = _skillRepository.GetAysenc(request.Id).Result;

            if (skill is null)
                return await Task.FromResult(false);

            if (await _skillRepository.ExistsAysenc(x => x.SkillName == request.SkillName &&
            x.KeyId != request.Id))
                return await Task.FromResult(false);


            skill.Edit(request.SkillName, request.Score);

            await _skillRepository.SaveAsync();


            return await Task.FromResult(true);

        }
    }
}
