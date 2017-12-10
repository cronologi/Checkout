using Application.Interfaces.Persistence;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Shared
{
    public class Repository<T>
        : IRepository<T>
        where T : class, IEntity

    {
        private readonly IDatabaseContext _database;

        public Repository(IDatabaseContext database)
        {
            _database = database;
        }

        public IQueryable<T> GetAll()
        {
            return _database.Set<T>();
        }

        public T Get(Guid id)
        {
            return _database.Set<T>()
                .SingleOrDefault(p => p.Id == id);
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await _database.Set<T>().FindAsync(id);
        }

        public void Add(T entity)
        {
            _database.Set<T>().Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _database.Set<T>().AddAsync(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _database.Set<T>().AddRange(entities);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _database.Set<T>().AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _database.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _database.Set<T>().UpdateRange(entities);
        }

        public void Remove(T entity)
        {
            _database.Set<T>().Remove(entity);
        }
    }
}
