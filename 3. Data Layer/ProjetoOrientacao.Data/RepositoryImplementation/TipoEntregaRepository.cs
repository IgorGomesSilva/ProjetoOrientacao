using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoOrientacao.Data.GenericRepository;
using ProjetoOrientacao.Data.RepositoryInterfaces;

namespace ProjetoOrientacao.Data.RepositoryImplementation
{
    public class TipoEntregaRepository
        : GenericRepository<TipoEntrega>, ITipoEntregaRepository, IDisposable
    {
    }
}
