namespace Educasfera.Formularios
{
    partial class FormCadastrarCursos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastroCursos = new System.Windows.Forms.TabPage();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCadastroLicoes = new System.Windows.Forms.TabPage();
            this.lbComboBoxLicao = new System.Windows.Forms.Label();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.txtNomeLicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCadastroArquivos = new System.Windows.Forms.TabPage();
            this.btSelecionarArquivo = new System.Windows.Forms.Button();
            this.comboBoxLicao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btIniciarCadastro = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCadastroCursos.SuspendLayout();
            this.tabCadastroLicoes.SuspendLayout();
            this.tabCadastroArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastroCursos);
            this.tabControl1.Controls.Add(this.tabCadastroLicoes);
            this.tabControl1.Controls.Add(this.tabCadastroArquivos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastroCursos
            // 
            this.tabCadastroCursos.Controls.Add(this.txtPreco);
            this.tabCadastroCursos.Controls.Add(this.txtDescricao);
            this.tabCadastroCursos.Controls.Add(this.txtNomeCurso);
            this.tabCadastroCursos.Controls.Add(this.label3);
            this.tabCadastroCursos.Controls.Add(this.label2);
            this.tabCadastroCursos.Controls.Add(this.label1);
            this.tabCadastroCursos.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroCursos.Name = "tabCadastroCursos";
            this.tabCadastroCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroCursos.Size = new System.Drawing.Size(665, 256);
            this.tabCadastroCursos.TabIndex = 0;
            this.tabCadastroCursos.Text = "Cadastro de Cursos";
            this.tabCadastroCursos.UseVisualStyleBackColor = true;
            this.tabCadastroCursos.Enter += new System.EventHandler(this.tabCadastroCursos_Enter);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(93, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(120, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(93, 109);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(224, 124);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(93, 21);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(233, 20);
            this.txtNomeCurso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço R$ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do curso :";
            // 
            // tabCadastroLicoes
            // 
            this.tabCadastroLicoes.Controls.Add(this.lbComboBoxLicao);
            this.tabCadastroLicoes.Controls.Add(this.comboBoxCursos);
            this.tabCadastroLicoes.Controls.Add(this.txtNomeLicao);
            this.tabCadastroLicoes.Controls.Add(this.label4);
            this.tabCadastroLicoes.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroLicoes.Name = "tabCadastroLicoes";
            this.tabCadastroLicoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroLicoes.Size = new System.Drawing.Size(665, 256);
            this.tabCadastroLicoes.TabIndex = 1;
            this.tabCadastroLicoes.Text = "Cadastro de Lições";
            this.tabCadastroLicoes.UseVisualStyleBackColor = true;
            this.tabCadastroLicoes.Enter += new System.EventHandler(this.tabCadastroLicoes_Enter);
            // 
            // lbComboBoxLicao
            // 
            this.lbComboBoxLicao.AutoSize = true;
            this.lbComboBoxLicao.Location = new System.Drawing.Point(19, 77);
            this.lbComboBoxLicao.Name = "lbComboBoxLicao";
            this.lbComboBoxLicao.Size = new System.Drawing.Size(137, 13);
            this.lbComboBoxLicao.TabIndex = 3;
            this.lbComboBoxLicao.Text = "Vincular curso a esta lição :";
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(162, 74);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(190, 21);
            this.comboBoxCursos.TabIndex = 2;
            // 
            // txtNomeLicao
            // 
            this.txtNomeLicao.Location = new System.Drawing.Point(111, 27);
            this.txtNomeLicao.Name = "txtNomeLicao";
            this.txtNomeLicao.Size = new System.Drawing.Size(185, 20);
            this.txtNomeLicao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome da Lição :";
            // 
            // tabCadastroArquivos
            // 
            this.tabCadastroArquivos.Controls.Add(this.btSelecionarArquivo);
            this.tabCadastroArquivos.Controls.Add(this.comboBoxLicao);
            this.tabCadastroArquivos.Controls.Add(this.label6);
            this.tabCadastroArquivos.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroArquivos.Name = "tabCadastroArquivos";
            this.tabCadastroArquivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroArquivos.Size = new System.Drawing.Size(665, 256);
            this.tabCadastroArquivos.TabIndex = 2;
            this.tabCadastroArquivos.Text = "Cadastro de Arquivos";
            this.tabCadastroArquivos.UseVisualStyleBackColor = true;
            this.tabCadastroArquivos.Enter += new System.EventHandler(this.tabCadastroArquivos_Enter);
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.Location = new System.Drawing.Point(32, 77);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(132, 23);
            this.btSelecionarArquivo.TabIndex = 2;
            this.btSelecionarArquivo.Text = "Selecionar Arquivo . . .";
            this.btSelecionarArquivo.UseVisualStyleBackColor = true;
            // 
            // comboBoxLicao
            // 
            this.comboBoxLicao.FormattingEnabled = true;
            this.comboBoxLicao.Location = new System.Drawing.Point(165, 28);
            this.comboBoxLicao.Name = "comboBoxLicao";
            this.comboBoxLicao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLicao.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Selecione a lição referente :";
            // 
            // btIniciarCadastro
            // 
            this.btIniciarCadastro.Image = global::Educasfera.Properties.Resources._290713162041_32;
            this.btIniciarCadastro.Location = new System.Drawing.Point(420, 288);
            this.btIniciarCadastro.Name = "btIniciarCadastro";
            this.btIniciarCadastro.Size = new System.Drawing.Size(69, 51);
            this.btIniciarCadastro.TabIndex = 10;
            this.btIniciarCadastro.UseVisualStyleBackColor = true;
            this.btIniciarCadastro.Click += new System.EventHandler(this.btIniciarCadastro_Click);
            this.btIniciarCadastro.Enter += new System.EventHandler(this.btIniciarCadastro_Enter);
            // 
            // btGravar
            // 
            this.btGravar.Image = global::Educasfera.Properties.Resources._2982_32x32;
            this.btGravar.Location = new System.Drawing.Point(4, 288);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(69, 51);
            this.btGravar.TabIndex = 6;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);

            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::Educasfera.Properties.Resources._290713161618_48;
            this.btPesquisar.Location = new System.Drawing.Point(93, 288);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(69, 51);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
           
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::Educasfera.Properties.Resources._7660_32x32;
            this.btExcluir.Location = new System.Drawing.Point(174, 288);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 48);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
           
            // 
            // btEditar
            // 
            this.btEditar.Image = global::Educasfera.Properties.Resources._6169_32x32;
            this.btEditar.Location = new System.Drawing.Point(258, 288);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(69, 51);
            this.btEditar.TabIndex = 9;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
          
            // 
            // btCancelar
            // 
            this.btCancelar.AccessibleDescription = "";
            this.btCancelar.Image = global::Educasfera.Properties.Resources.Delete_icon32x32;
            this.btCancelar.Location = new System.Drawing.Point(339, 288);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(69, 51);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
          
            // 
            // FormCadastrarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 348);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btIniciarCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cursos";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastroCursos.ResumeLayout(false);
            this.tabCadastroCursos.PerformLayout();
            this.tabCadastroLicoes.ResumeLayout(false);
            this.tabCadastroLicoes.PerformLayout();
            this.tabCadastroArquivos.ResumeLayout(false);
            this.tabCadastroArquivos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastroCursos;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCadastroLicoes;
        private System.Windows.Forms.TabPage tabCadastroArquivos;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btIniciarCadastro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeLicao;
        private System.Windows.Forms.Label lbComboBoxLicao;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Button btSelecionarArquivo;
        private System.Windows.Forms.ComboBox comboBoxLicao;
        private System.Windows.Forms.Label label6;
    }
}