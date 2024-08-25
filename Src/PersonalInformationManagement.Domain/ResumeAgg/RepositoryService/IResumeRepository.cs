using _0_FrameWork.FW.Domain;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Domain.ResumeAgg.RepositoryService
{
    public interface IResumeRepository : IRepositoryBase<long, Resume>
    {
        Task<List<Resume_GetAll_Response>> GetAllAsync(long userId);
    }
}
