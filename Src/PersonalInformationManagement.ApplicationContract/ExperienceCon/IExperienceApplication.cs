using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.ExperienceCon
{
    public interface IExperienceApplication
    {
        Task<List<Experience_GetAll_Request>> SearchAsync(Experience_Search_Request request);
        Task<bool> AddAsync(Experience_Add_Request request);
    }
}
