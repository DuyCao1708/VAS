﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VAS_DBEntities : DbContext
    {
        public VAS_DBEntities()
            : base("name=VAS_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CuaHangVatTu> CuaHangVatTu { get; set; }
        public virtual DbSet<DanhMucVatTu> DanhMucVatTu { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<NguyenVatLieu> NguyenVatLieu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThanhToanNganHang> ThanhToanNganHang { get; set; }
        public virtual DbSet<ThanhToanTrucTiep> ThanhToanTrucTiep { get; set; }
        public virtual DbSet<BaoGiaVatTu> BaoGiaVatTu { get; set; }
    }
}
