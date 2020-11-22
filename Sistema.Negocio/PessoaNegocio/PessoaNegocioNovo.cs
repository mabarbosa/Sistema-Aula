using Sistema.Dados.PessoaDados;
using Sistema.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.PessoaNegocio
{
    class PessoaNegocioNovo : PessoaNegocio
    {
        #region ATRIBUTOS E CONSTRUTOR
        private IPessoaDados pessoaDAO = null;

        public PessoaNegocioNovo(IPessoaDados pessoaDAO) : base(pessoaDAO)
        {
            this.pessoaDAO = pessoaDAO;
        }
        #endregion

        public override IList<Pessoa> BuscaTodasPessoas()
        {
            return new List<Pessoa>();
        }
    }
}
