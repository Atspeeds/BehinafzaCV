using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.EducationCon
{
    public interface IEducationApplication
    {
        Task<List<Education_GetAll_Response>> SearchAsync(Education_Search_Request request);
        Task<bool> AddAsync(Education_Add_Request request);
        Task<bool> EditAsync(Education_Edit_Request request);
        Task<Education_Edit_Request> GetDetailAsync(long id);
    }
}
