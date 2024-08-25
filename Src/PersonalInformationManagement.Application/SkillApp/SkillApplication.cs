using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace PersonalInformationManagement.Application.SkillApp
{
    public partial class SkillApplication: ISkillApplication
    {
        private readonly ISkillRepository _skillRepository;

        public SkillApplication(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

    

     
    }
}
