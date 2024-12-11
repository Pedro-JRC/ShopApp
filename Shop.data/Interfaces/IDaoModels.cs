

using Shop.data.Entities;

namespace Shop.data.Interfaces
{
    public interface IDaoModels<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
