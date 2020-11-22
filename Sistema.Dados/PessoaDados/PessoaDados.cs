using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;


namespace Sistema.Dados.PessoaDados
{
    public class PessoaDados : IPessoaDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private EstudodbEntities db = null;

        public PessoaDados(EstudodbEntities db)
        {
            this.db = db;
        }
        #endregion

        #region Pessoa
        public IList<Pessoa> BuscaTodasPessoas()
        {
            return db.Pessoa.ToList();
        }

        public Pessoa SalvaPessoa(Pessoa Pessoa)
        {
            db.Pessoa.Add(Pessoa);
            db.SaveChanges();

            return Pessoa;
        }

        public Pessoa AlteraPessoa(Pessoa Pessoa)
        {
            db.Entry<Pessoa>(Pessoa).State = EntityState.Modified;
            db.SaveChanges();

            return Pessoa;
        }

        public Pessoa SelecionaPessoaPorNome(String pessoa)
        {
            return db.Pessoa.SingleOrDefault(x => x.nome.Equals(pessoa));
        }
        #endregion
    }
}
