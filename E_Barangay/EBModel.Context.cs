﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Barangay
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EBarangayEntities : DbContext
    {
        public EBarangayEntities()
            : base("name=EBarangayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Barangay> Barangays { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Official> Officials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
    
        public virtual ObjectResult<spCitizen_getFullName_Result> spCitizen_getFullName()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCitizen_getFullName_Result>("spCitizen_getFullName");
        }
    }
}