using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PxxCore.IRepository;

namespace PxxCore.Repository.EFCore
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly DbContextBase dbContext;

        public BaseRepository(DbContextBase context)
        {
            dbContext = context;
        }


        #region Async
        public async Task<List<T>> GetListAsync()
        {
            return await dbContext.Set<T>().AsQueryable().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> expression)
        {
            return await dbContext.Set<T>().AsQueryable().AsNoTracking().Where(expression).ToListAsync();
        }

        public IQueryable<T> GetQuery()
        {
            return dbContext.Set<T>().AsQueryable().AsNoTracking();
        }

        public IQueryable<T> GetQuery(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().AsQueryable().AsNoTracking().Where(expression);
        }

        #endregion
    }
}
