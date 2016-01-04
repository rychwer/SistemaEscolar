namespace SistemaEscolar.View
{
    partial class CadastraSerie
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PesquisarSerie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ExcluirSerie = new System.Windows.Forms.Button();
            this.btn_AlterarSerie = new System.Windows.Forms.Button();
            this.btn_CadastraSerie = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 197);
            this.panel2.TabIndex = 13;
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
            // btn_PesquisarSerie
            // 
            this.btn_PesquisarSerie.Location = new System.Drawing.Point(348, 5);
            this.btn_PesquisarSerie.Name = "btn_PesquisarSerie";
            this.btn_PesquisarSerie.Size = new System.Drawing.Size(83, 23);
            this.btn_PesquisarSerie.TabIndex = 3;
            this.btn_PesquisarSerie.Text = "Pesquisar";
            this.btn_PesquisarSerie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_PesquisarSerie);
            this.panel1.Controls.Add(this.btn_ExcluirSerie);
            this.panel1.Controls.Add(this.btn_AlterarSerie);
            this.panel1.Controls.Add(this.btn_CadastraSerie);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 37);
            this.panel1.TabIndex = 12;
            // 
            // btn_ExcluirSerie
            // 
            this.btn_ExcluirSerie.Location = new System.Drawing.Point(237, 5);
            this.btn_ExcluirSerie.Name = "btn_ExcluirSerie";
            this.btn_ExcluirSerie.Size = new System.Drawing.Size(83, 23);
            this.btn_ExcluirSerie.TabIndex = 2;
            this.btn_ExcluirSerie.Text = "Excluir";
            this.btn_ExcluirSerie.UseVisualStyleBackColor = true;
            // 
            // btn_AlterarSerie
            // 
            this.btn_AlterarSerie.Location = new System.Drawing.Point(122, 5);
            this.btn_AlterarSerie.Name = "btn_AlterarSerie";
            this.btn_AlterarSerie.Size = new System.Drawing.Size(85, 23);
            this.btn_AlterarSerie.TabIndex = 1;
            this.btn_AlterarSerie.Text = "Alterar";
            this.btn_AlterarSerie.UseVisualStyleBackColor = true;
            // 
            // btn_CadastraSerie
            // 
            this.btn_CadastraSerie.Location = new System.Drawing.Point(8, 5);
            this.btn_CadastraSerie.Name = "btn_CadastraSerie";
            this.btn_CadastraSerie.Size = new System.Drawing.Size(85, 23);
            this.btn_CadastraSerie.TabIndex = 0;
            this.btn_CadastraSerie.Text = "Cadastrar";
            this.btn_CadastraSerie.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // CadastraSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Series";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PesquisarSerie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExcluirSerie;
        private System.Windows.Forms.Button btn_AlterarSerie;
        private System.Windows.Forms.Button btn_CadastraSerie;

    }
}