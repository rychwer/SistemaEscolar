using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class PessoaModel
    {

        private int codigo;
        private String nome, endereco, telefone, celular, cpf, rg, email;
        private String login, senha;
        private DateTime dataNascimento;

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public String Endereco
        {
            get { return this.endereco; }
            set { this.endereco = value; }
        }

        public String Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }

        public String Celular
        {
            get { return this.celular; }
            set { this.celular = value; }
        }

        public String Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public String RG
        {
            get { return this.rg; }
            set { this.rg = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public String Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public String Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public DateTime DataNascimento
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }

    }
}
