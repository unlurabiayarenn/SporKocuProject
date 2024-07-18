using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Application.Interfaces.Repository.Base
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new() //new() yenilenebilir yapıda olmak için kullanılır
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter=null); // belirlenen tip/varlık yapısında sorgulama yazılmasını sağlar.
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
       Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null); //burda asenkron yapıda çalışacak bir yapı mevcuttur.
        TEntity Add(TEntity entity);
        Task<TEntity> AddAsyc(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsyc(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> DeleteAsyc(TEntity entity);

        Task Hardelete(TEntity entity);

    }

}
