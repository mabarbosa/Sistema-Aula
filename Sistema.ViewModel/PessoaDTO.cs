using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.ViewModel
{
    public class PessoaDTO
    {
        public int codPessoa { get; set; }
        public Nullable<int> codProfissao { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public Nullable<int> idade { get; set; }
        public Nullable<System.DateTime> dataNascimento { get; set; }
        public string sexo { get; set; }
    }
}
