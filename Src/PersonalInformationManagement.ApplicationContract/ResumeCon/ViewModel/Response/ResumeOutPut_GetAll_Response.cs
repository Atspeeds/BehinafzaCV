using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.SkillCon;
using System.Collections.Generic;

namespace PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response
{
    public class ResumeOutPut_GetAll_Response
    {
        public List<Skill_GetAll_Response> Skills { get; set; } = null;
        public List<Education_GetAll_Response> Educations { get; set; } = null;
        public List<Experience_GetAll_Request> Experiences { get; set; } = null;
    }
}
