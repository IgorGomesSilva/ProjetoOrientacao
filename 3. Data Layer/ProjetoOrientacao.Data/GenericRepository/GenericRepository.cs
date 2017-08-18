using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoOrientacao.Data.DataContext;
using System.Linq.Expressions;
using System.Data.Entity;

namespace ProjetoOrientacao.Data.GenericRepository
{
    public abstract class GenericRepository<T>
            : IDisposable, IGenericRepository<T>  where T : class
    {
        ProjetoOrientacaoDataContext contexto = new ProjetoOrientacaoDataContext();

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = contexto.Set<T>();
            return query;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = contexto.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            contexto.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            contexto.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            contexto.Entry(entity).State = EntityState.Modified;          
        }

        public void Save()
        {
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
