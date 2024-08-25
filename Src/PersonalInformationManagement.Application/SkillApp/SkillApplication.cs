using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
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
