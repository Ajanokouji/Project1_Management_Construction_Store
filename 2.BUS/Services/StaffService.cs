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
    public class StaffService : IStaffService
    {
        IStaffResponsitories _StaffRepo;
        IPositionResponsitories _PositionRepo;
        IProducerResponsitories _ProducerRepo;
        IStoreResponsitories _StoreRepo;
        public StaffService()
        {
            _StaffRepo = new StaffResponsitories();
            _PositionRepo = new PositionResponsitories();
            _ProducerRepo = new ProducerResponsitories();
            _StoreRepo = new StoreResponsitories();
        }
        public string AddStaffs(StaffView p)
        {
            if (p == null) return "Unsuccessfully";
            var staff = new Staff()
            {
                IdStaff = p.IdStaff,
                IdPosition = p.IdPosition,
                IdStore = p.IdStore,
                Name = p.Name,
                Status = p.Status,
                Address = p.Address,
                BirthOfDate = p.BirthOfDate,
                Code = p.Code,
                Gender = p.Gender,
                PhoneNumber = p.PhoneNumber,
                Wage = p.Wage,
            };
            if (_StaffRepo.AddStaffs(staff)) return "Successfully";
            return "Unsuccessfully";
        }

        public string[] Gender()
        {
            string[] vs = new string[]
            {
                "Male",
                "Female"
            };
            return vs;
        }

        public List<StaffView> GetStaffs()
        {
            List<StaffView> list = new List<StaffView>();
            list = (from a in _StaffRepo.GetStaffs()
                    join b in _StoreRepo.GetStores() on a.IdStore equals b.IdStore
                    join c in _PositionRepo.GetPositions() on a.IdPosition equals c.IdPosition
                    select new StaffView()
                    {
                        IdPosition = c.IdPosition,
                        IdStaff = a.IdStaff,
                        IdStore = b.IdStore,
                        Name = a.Name,
                        Status = a.Status,
                        NameStore = b.Name,
                        Address = a.Address,
                        BirthOfDate = a.BirthOfDate,
                        Code = a.Code,
                        Gender = a.Gender,
                        NamePosition = c.Name,
                        PhoneNumber = a.PhoneNumber,
                        Wage = a.Wage,
                     }).ToList();
            return list;
        }

        public Staff GetStaffsById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<StaffView> GetStaffsByName(string name)
        {
            return GetStaffs().Where(c => c.Name.Contains(name) || c.Code.Contains(name)).ToList();
        }

        public List<Store> GetStores()
        {
            return _StoreRepo.GetStores().ToList();
        }

        public string RemoveStaffs(Guid id)
        {
            if (_StaffRepo.RemoveStaffs(id))
                return "Successful";
            return "Unsuccessful";
        }

        public string UpdateStaffs(StaffView p)
        {
            var staff = _StaffRepo.GetStaffs().FirstOrDefault(c => c.IdStaff == p.IdStaff);
            staff.IdStaff = p.IdStaff;
            staff.Name = p.Name;
            staff.Code = p.Code;
            staff.Wage = p.Wage;
            staff.Status = p.Status;
            staff.Address = p.Address;
            staff.PhoneNumber = p.PhoneNumber;
            staff.BirthOfDate = p.BirthOfDate;
            staff.Gender = p.Gender;
            staff.IdPosition = p.IdPosition;
            staff.IdStore = p.IdStore;
            if (_StaffRepo.UpdateStaffs(staff))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
