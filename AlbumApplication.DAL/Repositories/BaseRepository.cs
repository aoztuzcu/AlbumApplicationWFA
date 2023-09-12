using AlbumApplication.DAL.Context;
using AlbumApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlbumApplication.DAL.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly RecordShopContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository()
        {
            _context = new RecordShopContext();
            _dbSet = _context.Set<TEntity>();
        }
        public virtual TEntity Insert(TEntity entity)
        {
            _ = _dbSet.Add(entity);
            _ = _context.SaveChanges();
            return entity;
        }
        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _ = _context.SaveChanges();
        }
        public virtual void Delete(int id)
        {
            TEntity? entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            PropertyInfo isDeleted = typeof(TEntity).GetProperty("IsDeleted");
            if (isDeleted != null && isDeleted.PropertyType == typeof(bool))
            {
                isDeleted.SetValue(entity, true);
                _context.Entry(entity).State = EntityState.Modified;
                _ = _context.SaveChanges();
            }
        }
        public virtual List<TEntity> GetAll()
        {
            List<TEntity> list = _dbSet.ToList();
            return list;
        }
        public virtual TEntity GetById(int id)
        {
            TEntity result = _dbSet.Find(id);
            return result;
        }
        public virtual List<TEntity> Where(Func<TEntity, bool> filter)
        {
            List<TEntity> list = _dbSet.Where(filter).ToList();
            return list;
        }
        public virtual TEntity FirstEntity(Func<TEntity, bool> filter)
        {
            var entity = _dbSet.FirstOrDefault(filter);
            return entity;
        }
        public virtual IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }
}
