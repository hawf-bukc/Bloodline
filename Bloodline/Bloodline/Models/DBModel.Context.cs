﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bloodline.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<branch> branches { get; set; }
        public virtual DbSet<camp> camps { get; set; }
        public virtual DbSet<donation> donations { get; set; }
        public virtual DbSet<donor> donors { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<receiver> receivers { get; set; }
        public virtual DbSet<report> reports { get; set; }
        public virtual DbSet<shipment> shipments { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
    }
}