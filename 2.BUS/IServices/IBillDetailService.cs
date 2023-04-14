using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBillDetailService
    {
        public string Add(BillDetail bill);
        public string Update(BillDetail bill);
        public List<BillDetail> GetAll();
        public string Delete(BillDetail bill);
    }
}
