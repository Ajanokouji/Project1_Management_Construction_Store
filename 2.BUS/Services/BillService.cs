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
    public class BillService : IBillService
    {
        private IBillResponsitories _BillRepo;
        private IStaffResponsitories _StaffRepository;
        private IBillDetailResponsitory _billDetailRepo;
        public BillService()
        {
            _BillRepo = new BillResponsitories();
            _StaffRepository = new StaffResponsitories();
            _billDetailRepo = new BillDetailResponsitories();
        }
        public string Add(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Thêm thất bại";
            if (_BillRepo.Add(bill)) return "Thêm thành công";
            return "Thêm thành công";
        }

        public string Delete(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Xóa thất bại";
            var temp = _BillRepo.GetAll().FirstOrDefault(c => c.IdBill == bill.IdBill);
            if (_BillRepo.Delete(temp)) return "Xóa thành công";
            return "Xóa thành công";
        }

        public List<BillView> GetAll()
        {
            var list = (from a in _BillRepo.GetAll()
                        join b in _billDetailRepo.GetAll() on a.IdBill equals b.IdBill
                        join c in _StaffRepository.GetStaffs() on a.Staff.IdStaff equals c.IdStaff
                        select new BillView
                        {
                            IdBill = a.IdBill,
                            Code = a.Code,
                            CreatedDate = a.CreatedDate,
                            //PaymentedDate = a.PaymentedDate,
                            //ShipDate = a.ShipDate,
                            //ReceivedDate = a.ReceivedDate,
                            Status = a.Status,
                            //Price = b.Price,
                            StaffName = c.Name,
                        }).ToList();
            return list;
        }

        public List<BillView> GetAll(string input)
        {
            throw new NotImplementedException();
        }

        public string Update(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Xóa thất bại";
            var temp = _BillRepo.GetAll().FirstOrDefault(c => c.IdBill == bill.IdBill);
            if (_BillRepo.Delete(temp)) return "Xóa thành công";
            return "Xóa thành công";
        }

        List<Bill> IBillService.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Bill> IBillService.GetAll(string input)
        {
            throw new NotImplementedException();
        }
    }
}
