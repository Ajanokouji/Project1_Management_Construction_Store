﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class BillDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid IdBill { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IdMaterial { get; set; }

        [Required]
        [StringLength(30)]
        public string MaterialName { get; set; }

        public int Amount { get; set; }
        public Decimal Price { get; set; }
        public virtual Material Material { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
