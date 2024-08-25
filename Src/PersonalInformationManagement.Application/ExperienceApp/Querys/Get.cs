using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ExperienceApp
{
    public partial class ExperienceApplication
    {
        public Task<List<Experience_GetAll_Request>> SearchAsync(Experience_Search_Request request)
        {
            return _experiencerepository.SearchAsync(request);
        }
    }
}
