using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICustomerService
    {

        string AddCustomer(CustomerView p);
        string UpdateCustomer(CustomerView p);
        string DeleteCustomer(Guid id);
        List<CustomerView> GetCustomerViews();
        List<string> GetGender();
    }
}
