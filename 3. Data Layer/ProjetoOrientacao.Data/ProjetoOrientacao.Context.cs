﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoOrientacao.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjetoOrientacaoEntities : DbContext
    {
        public ProjetoOrientacaoEntities()
            : base("name=ProjetoOrientacaoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Entrega> Entrega { get; set; }
        public virtual DbSet<Etapa> Etapa { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Orientacao> Orientacao { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Projeto> Projeto { get; set; }
        public virtual DbSet<Situacao> Situacao { get; set; }
        public virtual DbSet<SituacaoProjeto> SituacaoProjeto { get; set; }
        public virtual DbSet<TipoEntrega> TipoEntrega { get; set; }
        public virtual DbSet<TipoOrientacao> TipoOrientacao { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPapel> UsuarioPapel { get; set; }
        public virtual DbSet<Papel> Papel { get; set; }
    }
}
