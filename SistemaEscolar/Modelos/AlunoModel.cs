using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class AlunoModel : PessoaModel
    {
        private DateTime dataMatricula;

        public DateTime DataMatricula
        {
            get { return this.dataMatricula; }
            set { this.dataMatricula = value; }
        }
    }
}
