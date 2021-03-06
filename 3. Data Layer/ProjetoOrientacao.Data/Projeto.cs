//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeto()
        {
            this.Entrega = new HashSet<Entrega>();
            this.Orientacao = new HashSet<Orientacao>();
            this.SituacaoProjeto = new HashSet<SituacaoProjeto>();
        }
    
        public int IdProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public Nullable<decimal> NotaProjeto { get; set; }
        public int IdPessoaAluno { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega> Entrega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orientacao> Orientacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SituacaoProjeto> SituacaoProjeto { get; set; }
    }
}
