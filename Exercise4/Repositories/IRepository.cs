using Exercise4.Classes;

namespace Exercise4.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Save(T entity);
    }
}
