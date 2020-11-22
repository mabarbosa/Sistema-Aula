using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;

namespace Sistema.Dados.ProfissaoDados
{
    interface IProfissaoDados
    {
        IList<Profissao> BuscaTodasProfissoes();

        Profissao SalvaProfissao(Profissao profissao);

        Profissao AlteraProfissao(Profissao profissao);

        Profissao SelecionaProfissaoPorNome(String profissao);
    }
}
