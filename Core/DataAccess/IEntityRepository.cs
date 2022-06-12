using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

        List<T> GetAllSync(Expression<Func<T, bool>> filter = null);
        T GetSync(Expression<Func<T, bool>> filter);
        void AddSync(T entity);
        void UpdateSync(T entity);
        void DeleteSync(T entity);
    }
}
