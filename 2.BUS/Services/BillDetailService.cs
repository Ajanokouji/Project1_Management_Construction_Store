using _1.DAL.IRepositories;
using _1.DAL.IResponsitories;
using _1.DAL.Models;
using _1.DAL.Repositories;
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
    public class BillDetailService : IBillDetailService
    {
        private IBillDetailResponsitory _billDetail;
        private IBillResponsitories _bill;
        private IStaffResponsitories _staff;
        public BillDetailService()
        {
            _billDetail = new BillDetailResponsitories();
            _bill = new BillResponsitories();
            _staff = new StaffResponsitories();
        }
        public string Add(BillDetail bill)
        {
            if (bill == null) return "Unsuccessfully";
            if (_billDetail.Add(bill)) return "Successfully";
            return "Successfully";
        }

        public string Delete(BillDetail bill)
        {
            if (bill == null) return "Unsuccessfully";
            var temp = _billDetail.GetAll().FirstOrDefault(c => c.IdMaterial == bill.IdMaterial);
            if (_billDetail.Delete(temp)) return "Successfully";
            return "Successfully";
        }

        public List<BillView> GetAll()
        {
            var list = (from a in _bill.GetAll()
                        join b in _staff.GetStaffs() on a.IdStaff equals b.IdStaff
                        select new BillView
                        {
                            IdBill = a.IdBill,
                            Code = b.Code,
                            CreatedDate = a.CreatedDate,
                            StaffName = b.Name,
                            Status = a.Status,

                        }).ToList();
            return list;
        }

        public string Update(BillView bill)
        {
            if (bill == null) return "Unsuccessfully";
            var temp = _bill.GetAll().FirstOrDefault(c => c.IdBill == bill.IdBill);
            temp.Status = bill.Status;
            if (_bill.Update(temp)) return "Successfully";
            return "Successfully";
        }

        public string Update(BillDetail bill)
        {
            throw new NotImplementedException();
        }

        List<BillDetail> IBillDetailService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
