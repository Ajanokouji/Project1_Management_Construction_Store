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
    public class ProducerResponsitories : IProducerResponsitories
    {
        private MaterialWarehouseDbContext _DbContext;

        public ProducerResponsitories() {
            _DbContext = new MaterialWarehouseDbContext();
        }
        public List<Producer> GetAll()
        {
            return _DbContext.producers.ToList();
        }
    }
}
