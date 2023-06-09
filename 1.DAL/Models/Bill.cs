﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Bill
    {
        //public Bill()
        //{
        //    IdBill = Guid.NewGuid();
        //}

        [Key]
        public Guid IdBill { get; set; }
        public Guid IdCustomer { get; set; }
        public Guid IdStaff { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }

    }
}
