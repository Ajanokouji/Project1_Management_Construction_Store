using _1.DAL.Context;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ResAccount : IResAccount
    {
        MaterialWarehouseDbContext _dbcontext;
        public ResAccount()
        {
            _dbcontext = new MaterialWarehouseDbContext();
        }

        public bool Add(Account obj)
        {
            if (obj == null) return false;
            _dbcontext.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Account> GetAll()
        {
            return _dbcontext.accounts.ToList();
        }

        public bool Changepass(Account obj)
        {
            if (obj == null) return false;
            var acc = GetAll().FirstOrDefault(c=>c.Username == obj.Username);
            acc.Password = obj.Password;
            _dbcontext.Update(acc);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
