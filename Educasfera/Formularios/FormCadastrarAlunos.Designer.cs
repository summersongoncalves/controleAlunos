namespace Educasfera.Formularios
{
    partial class FormCadastrarAlunos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btLiberarCadastro = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 357);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btCancelar);
            this.tabPage1.Controls.Add(this.btEditar);
            this.tabPage1.Controls.Add(this.btLiberarCadastro);
            this.tabPage1.Controls.Add(this.btExcluir);
            this.tabPage1.Controls.Add(this.btPesquisar);
            this.tabPage1.Controls.Add(this.dataNasc);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btGravar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataNasc
            // 
            this.dataNasc.CustomFormat = "dd/MM/yyy";
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNasc.Location = new System.Drawing.Point(126, 52);
            this.dataNasc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(103, 20);
            this.dataNasc.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome : ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(626, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listar todos Alunos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::Educasfera.Properties.Resources.Delete_icon32x32;
            this.btCancelar.Location = new System.Drawing.Point(388, 223);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 51);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Image = global::Educasfera.Properties.Resources.userAlter32x32;
            this.btEditar.Location = new System.Drawing.Point(313, 223);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(69, 51);
            this.btEditar.TabIndex = 8;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btLiberarCadastro
            // 
            this.btLiberarCadastro.Image = global::Educasfera.Properties.Resources.user32x32;
            this.btLiberarCadastro.Location = new System.Drawing.Point(238, 223);
            this.btLiberarCadastro.Name = "btLiberarCadastro";
            this.btLiberarCadastro.Size = new System.Drawing.Size(69, 51);
            this.btLiberarCadastro.TabIndex = 7;
            this.btLiberarCadastro.UseVisualStyleBackColor = true;
            this.btLiberarCadastro.Click += new System.EventHandler(this.btLiberarCadastro_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::Educasfera.Properties.Resources.userDelete32x32;
            this.btExcluir.Location = new System.Drawing.Point(163, 223);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(69, 51);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::Educasfera.Properties.Resources._290713161618_48;
            this.btPesquisar.Location = new System.Drawing.Point(88, 223);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(69, 51);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.pesquisarAluno_Click);
            // 
            // btGravar
            // 
            this.btGravar.Image = global::Educasfera.Properties.Resources._2982_32x32;
            this.btGravar.Location = new System.Drawing.Point(13, 223);
            this.btGravar.Name = "btGravar";
            this.btGravar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btGravar.Size = new System.Drawing.Size(69, 51);
            this.btGravar.TabIndex = 0;
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btnGravar);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Educasfera.Properties.Resources.Button_Refresh_32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(8, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carregar Lista";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCadastrarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 357);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.FormCadastrarAlunos_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btLiberarCadastro;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}