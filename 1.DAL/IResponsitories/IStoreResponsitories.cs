using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IStoreResponsitories
    {
        public bool AddStores(Store p);
        public bool RemoveStores(Guid id);
        public bool UpdateStores(Store p);
        public List<Store> GetStores();
        public Store GetStoresById(Guid id);
        public List<Store> GetStoresByName(string name);
    }
}
