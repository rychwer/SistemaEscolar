namespace SistemaEscolar.View
{
    partial class CadastraDisciplina
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
            this.btn_PesquisarDisciplina = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ExcluirDisciplina = new System.Windows.Forms.Button();
            this.btn_AlterarDisciplina = new System.Windows.Forms.Button();
            this.btn_CadastraDisciplina = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PesquisarDisciplina
            // 
            this.btn_PesquisarDisciplina.Location = new System.Drawing.Point(348, 5);
            this.btn_PesquisarDisciplina.Name = "btn_PesquisarDisciplina";
            this.btn_PesquisarDisciplina.Size = new System.Drawing.Size(83, 23);
            this.btn_PesquisarDisciplina.TabIndex = 3;
            this.btn_PesquisarDisciplina.Text = "Pesquisar";
            this.btn_PesquisarDisciplina.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_PesquisarDisciplina);
            this.panel1.Controls.Add(this.btn_ExcluirDisciplina);
            this.panel1.Controls.Add(this.btn_AlterarDisciplina);
            this.panel1.Controls.Add(this.btn_CadastraDisciplina);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 37);
            this.panel1.TabIndex = 10;
            // 
            // btn_ExcluirDisciplina
            // 
            this.btn_ExcluirDisciplina.Location = new System.Drawing.Point(237, 5);
            this.btn_ExcluirDisciplina.Name = "btn_ExcluirDisciplina";
            this.btn_ExcluirDisciplina.Size = new System.Drawing.Size(83, 23);
            this.btn_ExcluirDisciplina.TabIndex = 2;
            this.btn_ExcluirDisciplina.Text = "Excluir";
            this.btn_ExcluirDisciplina.UseVisualStyleBackColor = true;
            // 
            // btn_AlterarDisciplina
            // 
            this.btn_AlterarDisciplina.Location = new System.Drawing.Point(122, 5);
            this.btn_AlterarDisciplina.Name = "btn_AlterarDisciplina";
            this.btn_AlterarDisciplina.Size = new System.Drawing.Size(85, 23);
            this.btn_AlterarDisciplina.TabIndex = 1;
            this.btn_AlterarDisciplina.Text = "Alterar";
            this.btn_AlterarDisciplina.UseVisualStyleBackColor = true;
            // 
            // btn_CadastraDisciplina
            // 
            this.btn_CadastraDisciplina.Location = new System.Drawing.Point(8, 5);
            this.btn_CadastraDisciplina.Name = "btn_CadastraDisciplina";
            this.btn_CadastraDisciplina.Size = new System.Drawing.Size(85, 23);
            this.btn_CadastraDisciplina.TabIndex = 0;
            this.btn_CadastraDisciplina.Text = "Cadastrar";
            this.btn_CadastraDisciplina.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 197);
            this.panel2.TabIndex = 11;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(97, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(325, 20);
            this.txtDescricao.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código:";
            // 
            // CadastraDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CadastraDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Disciplina";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PesquisarDisciplina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExcluirDisciplina;
        private System.Windows.Forms.Button btn_AlterarDisciplina;
        private System.Windows.Forms.Button btn_CadastraDisciplina;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}