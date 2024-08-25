using PersonalInformationManagement.Application.Contract.ExperienceCon;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ExperienceApp
{
    public partial class ExperienceApplication
    {
        public async Task<bool> EditAsync(Experience_Edit_Request request)
        {
            var experience = _experiencerepository.GetAysenc(request.Id).Result;

            if (experience is null)
                return await Task.FromResult(false);

            if (await _experiencerepository.ExistsAysenc(x => x.Company == request.Company
            && x.JobTitle == request.JobTitle
            && x.KeyId != request.Id))
                return await Task.FromResult(false);


            experience.Edit(request.JobTitle, request.Company, request.StartDate, request.EndDate);

            await _experiencerepository.SaveAsync();

            return await Task.FromResult(true);

        }

    }
}
