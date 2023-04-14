using _1.DAL.IResponsitories;
using _1.DAL.Models;
using _1.DAL.Responsitories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class CustomerServices : ICustomerService
    {
        ICustomerResponsitories _iCustomerRepo;

        public CustomerServices()
        {
            _iCustomerRepo = new CustomerResponsitories();
        }
        public string AddCustomer(CustomerView p)
        {
            if (p == null)
            {
                return "Unsuccessful";
            }
            var KH = new Customer()
            {
                IdCustomer = p.IdCustomer,
                Code = p.Code,
                Name = p.Name,
                Status = p.Status,
            };
            if (_iCustomerRepo.AddCustomer(KH)) return "Successful";
            return "Unsuccessful";
        }

        public string DeleteCustomer(CustomerView p)
        {
            if (p == null)
            {
                return "Unsuccessful";
            }
            var KH = _iCustomerRepo.GetCustomerFromDB().FirstOrDefault(c => c.IdCustomer == p.IdCustomer);
            if (_iCustomerRepo.DeleteCustomer(KH)) return "Successful";
            return "Unsuccessful";
        }

        public List<CustomerView> GetCustomerViews()
        {
            List<CustomerView> lstctm = new List<CustomerView>();
            lstctm = (from n in _iCustomerRepo.GetCustomerFromDB().ToList()
                      select new CustomerView
                      {
                          IdCustomer = n.IdCustomer,
                          Code = n.Code,
                          Name = n.Name,
                          Status = n.Status,
                      }).ToList();
            return lstctm;
        }

        public List<string> GetGender()
        {
            return new List<string>() { "Male", "Female" };
        }

        public string UpdateCustomer(CustomerView p)
        {
            if (p == null)
            {
                return "Unsuccessful";
            }
            var KH = _iCustomerRepo.GetCustomerFromDB().FirstOrDefault(c => c.IdCustomer == p.IdCustomer);
            KH.IdCustomer = p.IdCustomer;
            KH.Code = p.Code;
            KH.Name = p.Name;
            KH.Status = p.Status;
            if (_iCustomerRepo.UpdateCustomer(KH)) return "Successful";
            return "Unsuccessful";
        }
    }
}
