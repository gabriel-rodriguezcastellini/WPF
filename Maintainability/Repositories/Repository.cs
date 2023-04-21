using Maintainability.Classes;

namespace Maintainability.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Save(T entity)
        {
            // Save entity
        }
    }
}
