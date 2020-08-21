using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);

        void Remove(TEntity entity);

        Task<IEnumerable<TEntity>> FindAllAsync();
    }
}
