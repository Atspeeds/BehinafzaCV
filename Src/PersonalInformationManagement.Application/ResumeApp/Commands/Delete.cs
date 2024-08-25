using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ResumeApp
{
    public partial class ResumeApplication
    {
        public Task<bool> DeleteAsync(long id)
        {
            return _resumerepository.DeleteAllResumeAsync(id);
        }
    }
}
