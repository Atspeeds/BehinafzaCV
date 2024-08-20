using _0_FrameWork.FW.Domain;
using System.Threading.Tasks;

namespace AccountManagement.Domain.UserAgg
{
    public interface IUserRepository : IRepositoryBase<long, User>
    {
        Task<User> GetUserBy(string phone);
    }
}
