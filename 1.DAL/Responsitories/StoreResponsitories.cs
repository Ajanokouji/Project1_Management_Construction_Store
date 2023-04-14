using _1.DAL.Context;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Responsitories
{
    public class StoreResponsitories : IStoreResponsitories
    {
        MaterialWarehouseDbContext _dbContext;
        public StoreResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool AddStores(Store p)
        {
            _dbContext.stores.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Store> GetStores()
        {
            return _dbContext.stores.ToList();
        }

        public Store GetStoresById(Guid id)
        {
            return _dbContext.stores.FirstOrDefault(c => c.IdStore == id);
        }

        public List<Store> GetStoresByName(string name)
        {
            return _dbContext.stores.Where(c => c.Name.Contains(name)).ToList();
        }

        public bool RemoveStores(Guid id)
        {
            var temp = _dbContext.stores.FirstOrDefault(c => c.IdStore == id);
            _dbContext.stores.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateStores(Store p)
        {
            var temp = _dbContext.stores.FirstOrDefault(c => c.IdStore == p.IdStore);
            _dbContext.stores.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
