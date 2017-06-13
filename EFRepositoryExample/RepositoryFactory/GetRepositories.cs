using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryFactory
{
    public static class GetRepositories
    {
        public static RepositoryBase.IRepository<Entities.Book> GetBookRepository(Enum.EnumRepoType repoType)
        {
            switch (repoType)
            {
                case Enum.EnumRepoType.EF6Repository:
                    //return new EF6_Repository.Repositories.EF6BookRepository();
                    break;

                case Enum.EnumRepoType.EFCoreRepository:
                    
                    break;
            }

            return null;
        }
    }
}
