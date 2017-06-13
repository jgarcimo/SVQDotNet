using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Repository.Repositories
{
    public abstract class EFCoreBaseRepository
    {
        protected EFCoreModel.SVQDotNetContext Context { get; set; }

        public EFCoreBaseRepository()
        {
            Context = new EFCoreModel.SVQDotNetContext();
        }
    }
}
