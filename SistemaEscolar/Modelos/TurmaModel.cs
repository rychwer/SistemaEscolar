using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Modelos
{
    class TurmaModel
    {
        private int id, qtdAlunos, duracao;
        private String descricao;
        private DateTime horarioAulas, dataInicial, dataFinal;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int QTDAlunos
        {
            get { return this.qtdAlunos; }
            set { this.qtdAlunos = value; }
        }

        public int Duracao
        {
            get { return this.duracao; }
            set { this.duracao = value; }
        }

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public DateTime HorarioAulas
        {
            get { return this.horarioAulas; }
            set { this.horarioAulas = value; }
        }

        public DateTime DataInicial
        {
            get { return this.dataInicial; }
            set { this.dataInicial = value; }
        }

        public DateTime DataFinal
        {
            get { return this.dataFinal; }
            set { this.dataFinal = value; }
        }
    }
}
