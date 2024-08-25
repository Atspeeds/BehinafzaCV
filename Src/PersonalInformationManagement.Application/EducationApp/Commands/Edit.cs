using PersonalInformationManagement.Application.Contract.EducationCon;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.EducationApp
{
    public partial class EducationApplication
    {
        public async Task<bool> EditAsync(Education_Edit_Request request)
        {
            var education = _educationRepository.GetAysenc(request.Id).Result;

            if (education is null)
                return await Task.FromResult(false);

            if (await _educationRepository.ExistsAysenc(x => x.Degree == request.Degree 
            && x.Institution == x.Institution
            && x.KeyId != request.Id))
                return await Task.FromResult(false);


            education.Edit(request.Degree, request.Institution, request.StartDate, request.EndDate);

            await _educationRepository.SaveAsync();

            return await Task.FromResult(true);

        }

    }
}
