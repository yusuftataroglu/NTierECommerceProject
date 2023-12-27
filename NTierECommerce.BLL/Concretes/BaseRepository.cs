using Microsoft.EntityFrameworkCore;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<string> Delete(T entity)
        {
            try
            {
                // _context.Remove(entity);
                entity.Status = Entities.Enums.DataStatus.Deleted;
                Update(entity);
                return "silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DestroyAllData(List<T> entity)
        {
            try
            {
                //foreach (var item in entity)
                //{
                //    _entities.Remove(item);
                //}
                _entities.RemoveRange(entity);
                await _context.SaveChangesAsync();
                return "veriler kalıcı olarak kaldırıldı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> DestroyData(T entity)
        {
            try
            {
               
                _entities.Remove(entity);
                await _context.SaveChangesAsync();
                return "veri kalıcı olarak kaldırıldı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> GetAllActive()
        {

            var activeData = _entities.Where(x => x.IsActive == true).ToList();
            return activeData;

        }

        public IEnumerable<T> GetAllPassive()
        {
            var activeData = _entities.Where(x => x.IsActive == false).ToList();
            return activeData;
        }

        public async Task<T> GetById(int id)
        {
            var data =await _entities.FirstOrDefaultAsync(x => x.Id == id);
            return data;
        }

        public async Task<string> Update(T entity)//Adidas
        {

            string result = "";
            try
            {
                switch (entity.Status)
                {
                    case Entities.Enums.DataStatus.Inserted:
                        entity.Status = Entities.Enums.DataStatus.Updated;
                        _context.Entry(entity).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        result = "Veri güncellendi";
                        break;
                    case Entities.Enums.DataStatus.Updated:
                        entity.Status = Entities.Enums.DataStatus.Updated;//parametrede zaten güncellenmiş olarak geliyor.
                        _context.Entry(entity).State= EntityState.Modified;
                        await _context.SaveChangesAsync();
                        result = "Veri güncellendi";
                        break;
                    case Entities.Enums.DataStatus.Deleted:
                        entity.Status = Entities.Enums.DataStatus.Deleted;
                        _context.Entry(entity).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        result = "Veri güncellendi";
                        break;

                }
                return result;
            }
            catch (Exception ex)
            {

                result = ex.Message;
                return result;
            }




            //var updated = await _entities.FirstOrDefaultAsync(x => x.Id == entity.Id);//Nike Airmax

            ////_context.Entry(updated).CurrentValues.SetValues(entity);

            //_context.Entry(entity).State = EntityState.Modified;

            //_context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
