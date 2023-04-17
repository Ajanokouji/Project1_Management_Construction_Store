using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface ICustomerResponsitories
    {
        bool AddCustomer(Customer p);
        bool UpdateCustomer(Customer p);
        bool DeleteCustomer(Guid id);
        Customer GetById(Guid id);
        List<Customer> GetCustomerFromDB();
    }
}
