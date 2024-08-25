using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ResumeApp
{
    public partial class ResumeApplication
    {
        public async Task<bool> EditAsync(Resume_Edit_Request request)
        {
            var resume = _resumerepository.GetAysenc(request.Id).Result;

            if (resume is null)
                return await Task.FromResult(false);

            if (await _resumerepository.ExistsAysenc(x => x.Summary == request.Summary
            && x.KeyId != request.Id))
                return await Task.FromResult(false);

            resume.Edit(request.Summary);

            await _resumerepository.SaveAsync();

            return await Task.FromResult(true);
        }

    }
}
