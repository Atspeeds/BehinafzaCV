using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace _0_FrameWork.FW.Domain
{
    public interface IRepositoryBase<TKey, T> where T : class
    {
        Task AddAysenc(T entity);
        Task<T> GetAysenc(TKey key);
        Task<IEnumerable<T>> GetAysenc();
        Task<bool> ExistsAysenc(Expression<Func<T, bool>> expression);
        public void Save();
        public Task SaveAsync();
    }
}
