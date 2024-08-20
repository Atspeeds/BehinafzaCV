using AccountManagement.Application.Contract.UserCon.ViewModel.Request;
using System.Threading.Tasks;

namespace AccountManagement.Application
{
    public interface IUserApplication
    {
        Task<bool> RegisterAsync(User_Register_Request request);
        Task<bool> LoginAsync(User_Login_Request request);
    }
}
