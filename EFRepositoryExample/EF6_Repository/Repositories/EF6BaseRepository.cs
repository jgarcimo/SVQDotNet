using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_Repository.Repositories
{
    public abstract class EF6BaseRepository
    {
        protected EF6Model.Model Model { get; set; }

        public EF6BaseRepository()
        {
            Model = new EF6Model.Model();
        }
    }
}
