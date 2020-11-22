using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;

namespace Sistema.Dados.PessoaDados
{
    public interface IPessoaDados
    {
        IList<Pessoa> BuscaTodasPessoas();

        Pessoa SalvaPessoa(Pessoa pessoa);

        Pessoa AlteraPessoa(Pessoa pessoa);

        Pessoa SelecionaPessoaPorNome(String pessoa);
    }
}
