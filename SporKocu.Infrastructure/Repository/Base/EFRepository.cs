using Microsoft.EntityFrameworkCore;
using SporKocu.Application.Interfaces.Repository.Base;
using SporKocu.Domain.Base;
using SporKocu.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Infrastructure.Repository.Base
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly SportContext _sporContext;

        public EFRepository(SportContext context)
        {
            _sporContext = context;
        }

        public TEntity Add(TEntity entity)
        {
            //throw new NotImplementedException();
            var addedEntity = _sporContext.Add(entity);
            addedEntity.State = EntityState.Added;
            _sporContext.SaveChanges();
            return entity;
            return entity;

        }

        public async Task<TEntity> AddAsyc(TEntity entity)
        {
            //throw new NotImplementedException();
            var addedEntity = _sporContext.Add(entity);
            addedEntity.State = EntityState.Added;
            await _sporContext.SaveChangesAsync();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = _sporContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _sporContext.SaveChanges();

        }

        public async Task DeleteAsyc(TEntity entity)
        {
            var deletedEntity = _sporContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await _sporContext.SaveChangesAsync();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return _sporContext.Set<TEntity>().SingleOrDefault(filter); //filter ile query gönderilecek ve bu değere göre sonuç verecek
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _sporContext.Set<TEntity>().ToList() : _sporContext.Set<TEntity>().Where(filter).ToList();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? await _sporContext.Set<TEntity>().ToListAsync() : await _sporContext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public Task Hardelete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            //throw new NotImplementedException();
            var uptatedEntity = _sporContext.Entry(entity);
            uptatedEntity.State = EntityState.Modified;
            _sporContext.SaveChanges();
            return entity;

        }

        public async Task<TEntity> UpdateAsyc(TEntity entity)
        {
            //throw new NotImplementedException();
            var uptatedEntity = _sporContext.Entry(entity);
            uptatedEntity.State = EntityState.Modified;
            await _sporContext.SaveChangesAsync();
            return entity;
        }
    }
}
