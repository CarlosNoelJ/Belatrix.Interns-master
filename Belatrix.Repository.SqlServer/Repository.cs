using System.Collections.Generic;

namespace Belatrix.Repository.SqlServer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ChinookContext _dbContext;

        public Repository(ChinookContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(T entity)
        {
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public IEnumerable<T> GetList()
        {
            return _dbContext.Set<T>();
        }

        public int Update(T entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
