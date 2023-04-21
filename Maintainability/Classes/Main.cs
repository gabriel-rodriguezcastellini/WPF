using Maintainability.Repositories;

namespace Maintainability.Classes
{
    public class Main
    {
        private readonly IRepository<BaseEntity> _repository;

        public Main(IRepository<BaseEntity> repository)
        {
            _repository = repository;
        }

        public void Save(BaseEntity entity)
        {
            _repository.Save(entity);
        }
    }
}
