using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Modelos;
using SistemaEscolar.Controllers;
using SistemaEscolar.View;

namespace SistemaEscolar
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            funcionario.Login = lb_login.Text.ToString();
            funcionario.Senha = lb_senha.Text.ToString();

            UsuarioController usuario = new UsuarioController();
            if (usuario.verificaUsuarioBanco(funcionario.Login, funcionario.Senha))
            {
                funcionario = usuario.usuarioLogado(funcionario.Login, funcionario.Senha);
                MessageBox.Show("Efetuado logon com sucesso");
                TelaInicial telainicial = new TelaInicial(funcionario.Nome);
                this.Hide();
                telainicial.Show();
            }
            else
            {
                MessageBox.Show("Não foi possivel efetuar o logon. Verifique o login e a senha.");
            }
        }

        private void lb_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
