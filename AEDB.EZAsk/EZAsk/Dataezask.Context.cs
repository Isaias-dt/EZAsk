﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EZAsk
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EZAskEntities : DbContext
    {
        public EZAskEntities()
            : base("name=EZAskEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Forum> Forum { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<MsgSuporte> MsgSuporte { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Resposta> Resposta { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Formacao> Formacao { get; set; }
    }
}
