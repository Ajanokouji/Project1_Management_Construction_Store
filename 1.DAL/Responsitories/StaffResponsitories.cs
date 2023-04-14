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
    public class StaffResponsitories : IStaffResponsitories
    {
        MaterialWarehouseDbContext _dbContext;
        public StaffResponsitories()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool AddStaffs(Staff p)
        {
            _dbContext.Add(p);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Staff> GetStaffs()
        {
            return _dbContext.staffs.ToList();
        }

        public Staff GetStaffsById(Guid id)
        {
            return _dbContext.staffs.FirstOrDefault(c => c.IdStaff == id);
        }

        public List<Staff> GetStaffsByName(string name)
        {
            return _dbContext.staffs.Where(c => c.Name.Contains(name)).ToList();
        }

        public bool RemoveStaffs(Guid id)
        {
            var temp = _dbContext.staffs.FirstOrDefault(c => c.IdStaff == id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateStaffs(Staff p)
        {
            var temp = _dbContext.staffs.FirstOrDefault(c => c.IdStaff == p.IdStaff);
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
