using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Customer
    {
        //public Customer()
        //{
        //    IdCustomer = Guid.NewGuid();
        //}

        [Key]
        public Guid IdCustomer { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(20)]

        public int Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
