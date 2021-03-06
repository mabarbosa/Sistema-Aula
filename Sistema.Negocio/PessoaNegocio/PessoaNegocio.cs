﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Infraestrutura;
using Sistema.Dados.PessoaDados;

namespace Sistema.Negocio.PessoaNegocio
{
    public class PessoaNegocio : IPessoaNegocio
    {
        #region ATRIBUTOS E CONSTRUTOR
        private IPessoaDados pessoaDAO = null;

        public PessoaNegocio(IPessoaDados pessoaDAO)
        {
            this.pessoaDAO = pessoaDAO;
        }
        #endregion

        #region PESSOA
        public virtual IList<Pessoa> BuscaTodasPessoas()
        {
            return pessoaDAO.BuscaTodasPessoas();
        }

        public Pessoa AlteraPessoa(Pessoa pessoa)
        {
            if (pessoa.idade > 25)
                return pessoaDAO.AlteraPessoa(pessoa);
            
            throw new Exception("Idade não permitida.");
        }

        public Pessoa SelecionaPessoaPorNome(String pessoa)
        {
            Pessoa _pessoa = null;

            if (!String.IsNullOrEmpty(pessoa))
            {
                _pessoa = pessoaDAO.SelecionaPessoaPorNome(pessoa);

                if (_pessoa == null)
                    throw new Exception("nulo");

                return _pessoa;
            }

            throw new Exception("Por favor, informe um nome.");
        }
        #endregion
    }
}