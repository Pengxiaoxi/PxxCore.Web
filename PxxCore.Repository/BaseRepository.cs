using System;
using System.Collections.Generic;
using System.Text;
using PxxCore.IRepository;

namespace PxxCore.Repository.EFCore
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {

    }
}
