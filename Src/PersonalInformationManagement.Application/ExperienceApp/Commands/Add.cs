using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ExperienceApp
{
    public partial class ExperienceApplication
    {
        public async Task<bool> AddAsync(Experience_Add_Request request)
        {
            var experince = new Experience(request.JobTitle,request.Company
                ,request.StartDate,request.EndDate,request.ResumeId);

            await _experiencerepository.AddAysenc(experince);
            await _experiencerepository.SaveAsync();
            return await Task.FromResult(true);
        }
    }
}
