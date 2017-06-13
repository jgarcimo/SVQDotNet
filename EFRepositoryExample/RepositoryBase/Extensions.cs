using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryBase
{
    public static class Extensions
    {
        public static void Delete<T>(this IRepository<T> repo, int id)
        {
            T entity = repo.GetSingle(id);
            repo.Delete(entity);
        }
    }
}
