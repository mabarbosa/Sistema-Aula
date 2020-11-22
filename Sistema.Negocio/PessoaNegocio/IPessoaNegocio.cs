using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;

namespace Sistema.Negocio.PessoaNegocio
{
    public interface IPessoaNegocio
    {
        IList<Pessoa> BuscaTodasPessoas();

        Pessoa AlteraPessoa(Pessoa pessoa);

        Pessoa SelecionaPessoaPorNome(String pessoa);
    }
}
