﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nacEntities : DbContext
    {
        public nacEntities()
            : base("name=nacEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<caja> caja { get; set; }
        public virtual DbSet<cajadiario> cajadiario { get; set; }
        public virtual DbSet<cajamov> cajamov { get; set; }
        public virtual DbSet<cajamovdetalle> cajamovdetalle { get; set; }
        public virtual DbSet<cargo> cargo { get; set; }
        public virtual DbSet<conceptopago> conceptopago { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<oficina> oficina { get; set; }
        public virtual DbSet<persona> persona { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_menu> rol_menu { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuario_rol> usuario_rol { get; set; }
    }
}