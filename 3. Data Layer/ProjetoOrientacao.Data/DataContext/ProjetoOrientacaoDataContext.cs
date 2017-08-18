using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjetoOrientacao.Data.DataContext
{
    public class ProjetoOrientacaoDataContext : DbContext
    {
        public ProjetoOrientacaoDataContext() : base("ProjetoOrientacaoEntities") { }
    }
}
