using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;
using System.Data.Entity;

namespace Sistema.Dados.ProfissaoDados
{
    public class ProfissaoDados : IProfissaoDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private EstudodbEntities db = null;

        public ProfissaoDados(EstudodbEntities db)
        {
            this.db = db;
        }
        #endregion

        #region PROFISSAO
        public IList<Profissao> BuscaTodasProfissoes()
        {
            return db.Profissao.ToList();
        }

        public Profissao SalvaProfissao(Profissao profissao)
        {
            db.Profissao.Add(profissao);
            db.SaveChanges();

            return profissao;
        }

        public Profissao AlteraProfissao(Profissao profissao)
        {
            db.Entry<Profissao>(profissao).State = EntityState.Modified;
            db.SaveChanges();

            return profissao;
        }

        public Profissao SelecionaProfissaoPorNome(String profissao)
        {
            return db.Profissao.SingleOrDefault(x => x.cargo.Equals(profissao));
        }
        #endregion
    }
}
