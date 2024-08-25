using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.EducationApp
{
    public partial class EducationApplication
    {
        public async Task<bool> AddAsync(Education_Add_Request request)
        {

            var education = new Education(request.Degree, request.Institution,
                request.StartDate, request.EndDate, request.ResumeId);

            await _educationRepository.AddAysenc(education);
            await _educationRepository.SaveAsync();
            return await Task.FromResult(true);
        }
    }
}
