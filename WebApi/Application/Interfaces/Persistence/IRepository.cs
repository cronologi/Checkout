using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Persistence
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T Get(Guid id);

        Task<T> GetAsync(Guid id);

        void Add(T entity);

        Task AddAsync(T entity);

        void AddRange(IEnumerable<T> entities);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);
    }
}
