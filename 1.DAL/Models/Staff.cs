﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Staff
    {
        //public Staff()
        //{
        //    IdStaff = Guid.NewGuid();
        //}

        [Key]
        public Guid IdStaff { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        public DateTime BirthOfDate { get; set; }

        public Decimal Wage { get; set; }
        public string Gender { get; set; }
        public int Status { get; set; }

        public Guid IdPosition { get; set; }
        public virtual Position Position { get; set; }
        public Guid IdStore { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
