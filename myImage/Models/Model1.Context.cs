﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myImage.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class my_imageEntities : DbContext
    {
        public my_imageEntities()
            : base("name=my_imageEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_img> tbl_img { get; set; }
        public virtual DbSet<tbl_order> tbl_order { get; set; }
        public virtual DbSet<tbl_print> tbl_print { get; set; }
        public virtual DbSet<tbl_register> tbl_register { get; set; }
    }
}
