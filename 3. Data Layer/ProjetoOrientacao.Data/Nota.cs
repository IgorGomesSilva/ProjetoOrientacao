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
    
    public partial class Nota
    {
        public int IdNota { get; set; }
        public int IdEntrega { get; set; }
        public System.DateTime DataAlteracao { get; set; }
        public decimal Valor { get; set; }
        public int IdUsuario { get; set; }
    
        public virtual Entrega Entrega { get; set; }
    }
}
