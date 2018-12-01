using System.Collections.Generic;

namespace Belatrix.Repository
{
    // para que tome el tipo que se necesita
    public interface IRepository<T> where T:class
    {
        // CRUD
        int Add(T entity);
        // Lista más liviana.
        IEnumerable<T> GetList();
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);
    }
}
