using _1.DAL.Context;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Responsitories
{
    public class CustomerResponsitories : ICustomerResponsitories
    {
        private MaterialWarehouseDbContext _dbContext;
        public CustomerResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }

        public bool AddCustomer(Customer p)
        {
            if (p == null) return false;
            p.IdCustomer = Guid.NewGuid();
            _dbContext.Customers.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteCustomer(Guid id)
        {
            var temp = _dbContext.Customers.FirstOrDefault(c => c.IdCustomer == id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public Customer GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Customers.FirstOrDefault(c => c.IdCustomer == id);
        }

        public List<Customer> GetCustomerFromDB()
        {
            return _dbContext.Customers.ToList();
        }

        public bool UpdateCustomer(Customer p)
        {
            if (p == null) return false;
            var temp = _dbContext.Customers.FirstOrDefault(x => x.IdCustomer == p.IdCustomer);
            temp.Code = p.Code;
            temp.Name = p.Name;
            temp.Status = p.Status;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
