using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class BillView
    {
        public Guid IdBill { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public string StaffName { get; set; }
    }
}
