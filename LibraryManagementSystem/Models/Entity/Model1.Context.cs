﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBKUTUPHANEEntities : DbContext
    {
        public DBKUTUPHANEEntities()
            : base("name=DBKUTUPHANEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLCEZALAR> TBLCEZALARs { get; set; }
        public virtual DbSet<TBLHAREKET> TBLHAREKETs { get; set; }
        public virtual DbSet<TBLKASA> TBLKASAs { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORIs { get; set; }
        public virtual DbSet<TBLKITAP> TBLKITAPs { get; set; }
        public virtual DbSet<TBLUYELER> TBLUYELERs { get; set; }
        public virtual DbSet<TBLYAZAR> TBLYAZARs { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONELs { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDAs { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIMs { get; set; }
        public virtual DbSet<TBLMESAJLAR> TBLMESAJLARs { get; set; }
        public virtual DbSet<TBLDUYURULAR> TBLDUYURULARs { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMINs { get; set; }
    
        // MOSTWRITER, veritabanında oluşturulan stored procedure ismidir, LINQ kartlar kısmında çalışır    
        public virtual ObjectResult<string> MOSTWRITER()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MOSTWRITER");
        }
    }
}
