using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RepositoryBase;


namespace EF6_Repository.Repositories
{
    public class EF6BookRepository : EF6BaseRepository, RepositoryBase.IRepository<Entities.Book>, RepositoryBase.IRepository<EF6Model.Book>
    {
        public void Add(Entities.Book entity)
        {
            ((IRepository<EF6Model.Book>)this).Add(Mappers.BookMapper.ToEF6Model(entity));
        }

        public void Delete(Entities.Book entity)
        {
            ((IRepository<EF6Model.Book>)this).Delete(Mappers.BookMapper.ToEF6Model(entity));
        }

        public void Edit(Entities.Book entity)
        {
            ((IRepository<EF6Model.Book>)this).Edit(Mappers.BookMapper.ToEF6Model(entity));
        }

        public IQueryable<Entities.Book> FindBy(Expression<Func<Entities.Book, bool>> predicate)
        {
            return null;
        }

        public IQueryable<Entities.Book> GetAll()
        {
            return ((IRepository<EF6Model.Book>)this).GetAll().Select(t => Mappers.BookMapper.ToBaseModel(t));
        }

        public Entities.Book GetSingle(int id)
        {
            return Mappers.BookMapper.ToBaseModel(((IRepository<EF6Model.Book>)this).GetSingle(id));
        }

        void IRepository<EF6Model.Book>.Add(EF6Model.Book entity)
        {
            Model.Book.Add(entity);
            Model.SaveChanges();
        }

        void IRepository<EF6Model.Book>.Delete(EF6Model.Book entity)
        {
            Model.Book.Remove(entity);
        }

        void IRepository<EF6Model.Book>.Edit(EF6Model.Book entity)
        {
            Model.Set<EF6Model.Book>().Attach(entity);
            Model.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Model.SaveChanges();            
        }

        IQueryable<EF6Model.Book> IRepository<EF6Model.Book>.FindBy(Expression<Func<EF6Model.Book, bool>> predicate)
        {
            return Model.Book.Where(predicate);
        }

        IQueryable<EF6Model.Book> IRepository<EF6Model.Book>.GetAll()
        {
            return Model.Book.AsQueryable();
        }

        EF6Model.Book IRepository<EF6Model.Book>.GetSingle(int id)
        {
            return Model.Book.SingleOrDefault(t => t.BookId == id);
        }
    }
}
