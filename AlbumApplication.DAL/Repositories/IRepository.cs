using AlbumApplication.Data.Entities;

namespace AlbumApplication.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetQueryable();
        public TEntity Insert(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(int id);
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public List<TEntity> Where(Func<TEntity, bool> filter);
        public TEntity FirstEntity(Func<TEntity, bool> filter);
    }
}