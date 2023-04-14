using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IResponsitories
{
    public interface IStaffResponsitories
    {
        public bool AddStaffs(Staff p);
        public bool RemoveStaffs(Guid id);
        public bool UpdateStaffs(Staff p);
        public List<Staff> GetStaffs();
        public Staff GetStaffsById(Guid id);
        public List<Staff> GetStaffsByName(string name);
    }
}
