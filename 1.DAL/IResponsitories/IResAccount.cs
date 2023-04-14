using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IResAccount
    {
        public bool Add(Account obj);
        public bool Changepass(Account obj);
        public List<Account> GetAll();
    }
}
