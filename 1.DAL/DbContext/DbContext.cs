﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Context
{
    public class MaterialWarehouseDbContext : DbContext
    {
        public MaterialWarehouseDbContext()
        {

        }

        public MaterialWarehouseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=DuAn1;Persist Security Info=True;User ID=PH26922;Password=tri01637126999");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetail>().HasKey(e => new { e.IdMaterial, e.IdBill });
            modelBuilder.Entity<Account>().HasIndex(e => e.Username).IsUnique();
        }
        public DbSet<Bill> bills { get; set; }
        public DbSet<BillDetail> billDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialDetail> MaterialDetails { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Account> accounts { get; set; }
    }
}