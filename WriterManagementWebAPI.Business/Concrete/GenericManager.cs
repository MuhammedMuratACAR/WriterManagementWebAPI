using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.Entities.Interfaces;

namespace WriterManagementWebAPI.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity:class,ITable,new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _genericDal.AddAsync(entity);
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await _genericDal.FindByIdAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await _genericDal.RemoveAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
