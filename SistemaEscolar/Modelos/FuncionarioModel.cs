using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Modelos
{
    class FuncionarioModel : PessoaModel
    {
        private DateTime dataAdmissao;

        public DateTime DataAdmissao
        {
            get { return this.dataAdmissao; }
            set { this.dataAdmissao = value; }
        }
    }
}
