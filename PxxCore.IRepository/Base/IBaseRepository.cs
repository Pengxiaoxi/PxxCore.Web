using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PxxCore.IRepository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        Task<List<T>> GetListAsync();

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression);

        IQueryable<T> GetQuery();

        IQueryable<T> GetQuery(Expression<Func<T, bool>> expression);
    }
}
