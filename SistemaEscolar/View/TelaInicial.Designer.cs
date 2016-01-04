namespace SistemaEscolar.View
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastroAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGerenciamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadDisciplinaProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadAlunoTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadNotasFrequencia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConsultaNotasFrequencia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_NomeUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastroAluno,
            this.MenuGerenciamento,
            this.MenuAdministrativo,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastroAluno
            // 
            this.MenuCadastroAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCadastroAluno,
            this.MenuItemCadastroTurmas,
            this.MenuItemCadastroSeries,
            this.MenuItemCadastroDisciplinas,
            this.MenuItemCadastroProfessores});
            this.MenuCadastroAluno.Name = "MenuCadastroAluno";
            this.MenuCadastroAluno.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastroAluno.Text = "Cadastro";
            // 
            // MenuItemCadastroAluno
            // 
            this.MenuItemCadastroAluno.Name = "MenuItemCadastroAluno";
            this.MenuItemCadastroAluno.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCadastroAluno.Text = "Cadastro de Alunos";
            this.MenuItemCadastroAluno.Click += new System.EventHandler(this.MenuItemCadastroAluno_Click);
            // 
            // MenuItemCadastroTurmas
            // 
            this.MenuItemCadastroTurmas.Name = "MenuItemCadastroTurmas";
            this.MenuItemCadastroTurmas.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCadastroTurmas.Text = "Cadastro de Turmas";
            this.MenuItemCadastroTurmas.Click += new System.EventHandler(this.MenuItemCadastroTurmas_Click);
            // 
            // MenuItemCadastroSeries
            // 
            this.MenuItemCadastroSeries.Name = "MenuItemCadastroSeries";
            this.MenuItemCadastroSeries.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCadastroSeries.Text = "Cadastro das Series";
            this.MenuItemCadastroSeries.Click += new System.EventHandler(this.cadastroDeSeriesToolStripMenuItem_Click);
            // 
            // MenuItemCadastroDisciplinas
            // 
            this.MenuItemCadastroDisciplinas.Name = "MenuItemCadastroDisciplinas";
            this.MenuItemCadastroDisciplinas.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCadastroDisciplinas.Text = "Cadastro de Disciplinas";
            this.MenuItemCadastroDisciplinas.Click += new System.EventHandler(this.MenuItemCadastroDisciplinas_Click);
            // 
            // MenuItemCadastroProfessores
            // 
            this.MenuItemCadastroProfessores.Name = "MenuItemCadastroProfessores";
            this.MenuItemCadastroProfessores.Size = new System.Drawing.Size(200, 22);
            this.MenuItemCadastroProfessores.Text = "Cadastro de Professores";
            this.MenuItemCadastroProfessores.Click += new System.EventHandler(this.MenuItemCadastroProfessores_Click);
            // 
            // MenuGerenciamento
            // 
            this.MenuGerenciamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCadDisciplinaProfessores,
            this.MenuItemCadAlunoTurmas,
            this.MenuItemCadMatricula,
            this.MenuItemCadNotasFrequencia,
            this.MenuItemConsultaNotasFrequencia});
            this.MenuGerenciamento.Name = "MenuGerenciamento";
            this.MenuGerenciamento.Size = new System.Drawing.Size(100, 20);
            this.MenuGerenciamento.Text = "Gerenciamento";
            // 
            // MenuItemCadDisciplinaProfessores
            // 
            this.MenuItemCadDisciplinaProfessores.Name = "MenuItemCadDisciplinaProfessores";
            this.MenuItemCadDisciplinaProfessores.Size = new System.Drawing.Size(287, 22);
            this.MenuItemCadDisciplinaProfessores.Text = "Cadastrar Disciplinas para os Professores";
            this.MenuItemCadDisciplinaProfessores.Click += new System.EventHandler(this.MenuItemCadDisciplinaProfessores_Click);
            // 
            // MenuItemCadAlunoTurmas
            // 
            this.MenuItemCadAlunoTurmas.Name = "MenuItemCadAlunoTurmas";
            this.MenuItemCadAlunoTurmas.Size = new System.Drawing.Size(287, 22);
            this.MenuItemCadAlunoTurmas.Text = "Cadastrar Alunos em Turmas";
            this.MenuItemCadAlunoTurmas.Click += new System.EventHandler(this.MenuItemCadAlunoTurmas_Click);
            // 
            // MenuItemCadMatricula
            // 
            this.MenuItemCadMatricula.Name = "MenuItemCadMatricula";
            this.MenuItemCadMatricula.Size = new System.Drawing.Size(287, 22);
            this.MenuItemCadMatricula.Text = "Efetuar Matricula de Alunos";
            this.MenuItemCadMatricula.Click += new System.EventHandler(this.MenuItemCadMatricula_Click);
            // 
            // MenuItemCadNotasFrequencia
            // 
            this.MenuItemCadNotasFrequencia.Name = "MenuItemCadNotasFrequencia";
            this.MenuItemCadNotasFrequencia.Size = new System.Drawing.Size(287, 22);
            this.MenuItemCadNotasFrequencia.Text = "Lançar e consultar notas";
            this.MenuItemCadNotasFrequencia.Click += new System.EventHandler(this.MenuItemCadNotasFrequencia_Click);
            // 
            // MenuItemConsultaNotasFrequencia
            // 
            this.MenuItemConsultaNotasFrequencia.Name = "MenuItemConsultaNotasFrequencia";
            this.MenuItemConsultaNotasFrequencia.Size = new System.Drawing.Size(287, 22);
            this.MenuItemConsultaNotasFrequencia.Text = "Lançar e consultar frequência";
            this.MenuItemConsultaNotasFrequencia.Click += new System.EventHandler(this.MenuItemConsultaNotasFrequencia_Click);
            // 
            // MenuAdministrativo
            // 
            this.MenuAdministrativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCadFuncionarios,
            this.relatóriosToolStripMenuItem});
            this.MenuAdministrativo.Name = "MenuAdministrativo";
            this.MenuAdministrativo.Size = new System.Drawing.Size(97, 20);
            this.MenuAdministrativo.Text = "Administrativo";
            // 
            // MenuItemCadFuncionarios
            // 
            this.MenuItemCadFuncionarios.Name = "MenuItemCadFuncionarios";
            this.MenuItemCadFuncionarios.Size = new System.Drawing.Size(208, 22);
            this.MenuItemCadFuncionarios.Text = "Cadastro de Funcionarios";
            this.MenuItemCadFuncionarios.Click += new System.EventHandler(this.MenuItemCadFuncionarios_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lb_NomeUsuario
            // 
            this.lb_NomeUsuario.AutoSize = true;
            this.lb_NomeUsuario.Location = new System.Drawing.Point(771, 5);
            this.lb_NomeUsuario.Name = "lb_NomeUsuario";
            this.lb_NomeUsuario.Size = new System.Drawing.Size(115, 13);
            this.lb_NomeUsuario.TabIndex = 1;
            this.lb_NomeUsuario.Text = "Logado com o usuário:";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lb_NomeUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCHOOL - Sistema de Gerenciamento Escolar";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroTurmas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroSeries;
        private System.Windows.Forms.ToolStripMenuItem MenuGerenciamento;
        private System.Windows.Forms.ToolStripMenuItem MenuAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroProfessores;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadDisciplinaProfessores;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadAlunoTurmas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadMatricula;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadNotasFrequencia;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConsultaNotasFrequencia;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadFuncionarios;
        private System.Windows.Forms.Label lb_NomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
    }
}