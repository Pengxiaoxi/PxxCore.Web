using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PxxCore.IRepository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        Task<int> SaveChanges();

        Task<List<T>> GetList();

    }
}
