﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cv_Asp.net.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Deneyimler> Tbl_Deneyimler { get; set; }
        public virtual DbSet<Tbl_Egitim> Tbl_Egitim { get; set; }
        public virtual DbSet<Tbl_Hakkımda> Tbl_Hakkımda { get; set; }
        public virtual DbSet<Tbl_Hobiler> Tbl_Hobiler { get; set; }
        public virtual DbSet<Tbl_İletisim> Tbl_İletisim { get; set; }
        public virtual DbSet<Tbl_Sertifikalar> Tbl_Sertifikalar { get; set; }
        public virtual DbSet<Tbl_Yetenek> Tbl_Yetenek { get; set; }
    }
}
