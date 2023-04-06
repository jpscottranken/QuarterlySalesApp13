using System.Collections.Generic;

namespace QuarterlySalesApp.Models.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
