using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using RepositoryBase;

namespace EFCore_Repository.Repositories
{
    public class EFCoreBookRepository : EFCoreBaseRepository, RepositoryBase.IRepository<Entities.Book>, RepositoryBase.IRepository<EFCoreModel.Book>
    {
        public void Add(Entities.Book entity)
        {
            ((IRepository<EFCoreModel.Book>)this).Add(Mappers.BookMapper.ToEFCoreModel(entity));
        }

        public void Delete(Entities.Book entity)
        {
            ((IRepository<EFCoreModel.Book>)this).Delete(Mappers.BookMapper.ToEFCoreModel(entity));
        }

        public void Edit(Entities.Book entity)
        {
            ((IRepository<EFCoreModel.Book>)this).Edit(Mappers.BookMapper.ToEFCoreModel(entity));
        }

        public IQueryable<Entities.Book> FindBy(Expression<Func<Entities.Book, bool>> predicate)
        {
            return null;
        }

        public IQueryable<Entities.Book> GetAll()
        {
            return ((IRepository<EFCoreModel.Book>)this).GetAll().Select(t => Mappers.BookMapper.ToBaseModel(t));
        }

        public Entities.Book GetSingle(int id)
        {
            return Mappers.BookMapper.ToBaseModel(((IRepository<EFCoreModel.Book>)this).GetSingle(id));
        }

        void IRepository<EFCoreModel.Book>.Add(EFCoreModel.Book entity)
        {
            Context.Book.Add(entity);
            Context.SaveChanges();
        }

        void IRepository<EFCoreModel.Book>.Delete(EFCoreModel.Book entity)
        {
            Context.Book.Remove(entity);
            Context.SaveChanges();
        }

        void IRepository<EFCoreModel.Book>.Edit(EFCoreModel.Book entity)
        {
            Context.Set<EFCoreModel.Book>().Attach(entity);
            Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        IQueryable<EFCoreModel.Book> IRepository<EFCoreModel.Book>.FindBy(Expression<Func<EFCoreModel.Book, bool>> predicate)
        {
            return Context.Book.Where(predicate);
        }

        IQueryable<EFCoreModel.Book> IRepository<EFCoreModel.Book>.GetAll()
        {
            return Context.Book.AsQueryable();
        }

        EFCoreModel.Book IRepository<EFCoreModel.Book>.GetSingle(int id)
        {
            return Context.Book.SingleOrDefault(t => t.BookId == id);
        }
    }
}
