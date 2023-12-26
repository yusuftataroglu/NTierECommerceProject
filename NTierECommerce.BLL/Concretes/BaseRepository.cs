using Microsoft.EntityFrameworkCore;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Base;

namespace NTierECommerce.BLL.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;

        public BaseRepository(ECommerceContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }


        public async Task<string> Create(T entity)
        {
            //_context.Set<T>().Add(entity);
            try
            {
                await _entities.AddAsync(entity);
                _context.SaveChanges();
                return "Kayıt başarılı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Task<string> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DestroyAllData(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> DestroyData(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> GetAllActive()
        {
            //return _entities.AsEnumerable();
            return _entities.AsEnumerable().ToList();

        }

        public IEnumerable<T> GetAllPassive()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(int id)
        {
            var entity = await _entities.FirstOrDefaultAsync(x => x.Id == id);
            if (entity!=null)
            {
                return entity;
            }
            else
            {
                return default(T);
            }
        }

        public async Task<string> Update(T newEntity)//Adidas
        {
            var oldEntity = await _entities.FirstOrDefaultAsync(x => x.Id == newEntity.Id);
            if (oldEntity!=null)
            {
                try
                {
                    _context.Entry(oldEntity).CurrentValues.SetValues(newEntity);
                    return "Güncelleme başarılı!";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                
            }
            else
            {
                return "Böyle bir veri bulunmamakta!";
            }



            //_context.Entry(entity).State = EntityState.Modified;

            //_context.SaveChanges();
        }
    }
}
