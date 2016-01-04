using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Modelos
{
    class CursoModel
    {
        private int codigo;
        private String descricao;

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
    }
}
