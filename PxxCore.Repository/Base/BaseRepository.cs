using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<T>> GetList()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
