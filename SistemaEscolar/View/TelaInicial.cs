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

namespace SistemaEscolar.View
{
    public partial class TelaInicial : Form
    {

        public TelaInicial(String nome)
        {
            InitializeComponent();
            lb_NomeUsuario.Text = "Logado com o usuário: "+nome;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraSerie CadastraSerie = new CadastraSerie();
            CadastraSerie.ShowDialog();
        }

        private void lb_nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuItemCadDisciplinaSerie_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemCadMatricula_Click(object sender, EventArgs e)
        {
            EfetuaMatricula EfetuaMatricula = new EfetuaMatricula();
            EfetuaMatricula.ShowDialog();
        }

        private void MenuItemConsultaNotasFrequencia_Click(object sender, EventArgs e)
        {
            LancarFrequencia LancarFrequencia = new LancarFrequencia();
            LancarFrequencia.ShowDialog();
        }

        private void MenuItemCadastroAluno_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastroAlunos = new CadastroAlunos();
            cadastroAlunos.ShowDialog();
        }

        private void MenuItemCadastroProfessores_Click(object sender, EventArgs e)
        {
            CadastraProfessores CadastraProfessores = new CadastraProfessores();
            CadastraProfessores.ShowDialog();
        }

        private void MenuItemCadFuncionarios_Click(object sender, EventArgs e)
        {
            CadastraFuncionario CadastraFuncionario = new CadastraFuncionario();
            CadastraFuncionario.ShowDialog();
        }

        private void MenuItemCadastroDisciplinas_Click(object sender, EventArgs e)
        {
            CadastraDisciplina CadastraDisciplina = new CadastraDisciplina();
            CadastraDisciplina.ShowDialog();
        }

        private void MenuItemCadastroTurmas_Click(object sender, EventArgs e)
        {
            CadastraTurma CadastraTurma = new CadastraTurma();
            CadastraTurma.ShowDialog();
        }

        private void MenuItemCadDisciplinaProfessores_Click(object sender, EventArgs e)
        {
            CadastraDisciplinasProfessores CadastraDisciplinasProfessores = new CadastraDisciplinasProfessores();
            CadastraDisciplinasProfessores.ShowDialog();
        }

        private void MenuItemCadAlunoTurmas_Click(object sender, EventArgs e)
        {
            CadastrarAlunosTurmas CadastrarAlunosTurmas = new CadastrarAlunosTurmas();
            CadastrarAlunosTurmas.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemCadNotasFrequencia_Click(object sender, EventArgs e)
        {
            LancarNotas LancarNotas = new LancarNotas();
            LancarNotas.ShowDialog();
        }

    }
}
