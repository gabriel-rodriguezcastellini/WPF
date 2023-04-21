using Exercise4.Repositories;

namespace Exercise4.Classes
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
