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
    
    public partial class SituacaoProjeto
    {
        public int IdProjeto { get; set; }
        public int IdSituacao { get; set; }
        public System.DateTime DataAlteracao { get; set; }
    
        public virtual Projeto Projeto { get; set; }
        public virtual Situacao Situacao { get; set; }
    }
}
