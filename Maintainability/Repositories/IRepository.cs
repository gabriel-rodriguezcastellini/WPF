using Maintainability.Classes;

namespace Maintainability.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Save(T entity);
    }
}
