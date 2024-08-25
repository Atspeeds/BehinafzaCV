using PersonalInformationManagement.Application.Contract.EducationCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.EducationApp
{
    public partial class EducationApplication
    {
        public Task<List<Education_GetAll_Response>> SearchAsync(Education_Search_Request request)
        {
            return _educationRepository.SearchAsync(request);
        }
    }
}
