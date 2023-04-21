using Exercise4.Classes;

namespace Exercise4.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Save(T entity)
        {
            // Save entity
        }
    }
}
