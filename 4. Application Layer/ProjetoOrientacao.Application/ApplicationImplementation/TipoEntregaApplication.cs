using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoOrientacao.Data.RepositoryInterfaces;
using ProjetoOrientacao.Data;
using System.Linq.Expressions;
using ProjetoOrientacao.Data.RepositoryImplementation;

namespace ProjetoOrientacao.Application.ApplicationImplementation
{
    public class TipoEntregaApplication
    {
        private TipoEntregaRepository TipoEntregaRepository;

        public TipoEntregaApplication()
        {
            TipoEntregaRepository = new TipoEntregaRepository();
        }       

        public IList<TipoEntrega> TodosTiposEntrega()
        {
            return TipoEntregaRepository.GetAll().ToList();
        }

        public TipoEntrega ObterTipoEntrega
            (Expression<Func<TipoEntrega, bool>> predicate)
        {
            return TipoEntregaRepository.Find(predicate).FirstOrDefault();
        }

        public IDictionary<string, IList<string>> SalvarTipoEntrega
            (TipoEntrega tipoEntrega)
        {
            var erros = new Dictionary<string, IList<string>>();

            try
            {
                if (tipoEntrega.IdTipoEntrega == 0)
                {
                    TipoEntregaRepository.Add(tipoEntrega);
                }

                else
                {
                    TipoEntregaRepository.Edit(tipoEntrega);
                }

                TipoEntregaRepository.Save();
            }

            catch (Exception ex)
            {
                erros.Add("ErroSalvarTipoEntrega", new List<string>() { ex.Message });
            }

            return erros;
        }

        public IDictionary<string, IList<string>> ExcluirTipoEntrega
            (TipoEntrega tipoEntrega)
        {
            var erros = new Dictionary<string, IList<string>>();

            try
            {
                TipoEntregaRepository.Delete(tipoEntrega);

                TipoEntregaRepository.Save();
            }

            catch (Exception ex)
            {
                erros.Add("ErroExcluirTipoEntrega", new List<string>() { ex.Message });
            }

            return erros;
        }
    }
}
