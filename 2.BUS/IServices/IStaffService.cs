using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IStaffService
    {
        public string AddStaffs(StaffView p);
        public List<StaffView> GetStaffs();
        public List<Store> GetStores();
        public string RemoveStaffs(Guid id);
        public string UpdateStaffs(StaffView p);
        public Staff GetStaffsById(Guid id);
        public List<StaffView> GetStaffsByName(string name);
        public string[] Gender();
    }
}
