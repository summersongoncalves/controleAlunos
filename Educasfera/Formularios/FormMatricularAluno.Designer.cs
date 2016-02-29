namespace Educasfera.Formularios
{
    partial class FormMatricularAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNomeAluno = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNomeCurso = new System.Windows.Forms.ComboBox();
            this.btMatricular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno :";
            // 
            // comboBoxNomeAluno
            // 
            this.comboBoxNomeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomeAluno.FormattingEnabled = true;
            this.comboBoxNomeAluno.Location = new System.Drawing.Point(98, 41);
            this.comboBoxNomeAluno.Name = "comboBoxNomeAluno";
            this.comboBoxNomeAluno.Size = new System.Drawing.Size(303, 21);
            this.comboBoxNomeAluno.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMatricular);
            this.groupBox1.Controls.Add(this.comboBoxNomeCurso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxNomeAluno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrícula de Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso :";
            // 
            // comboBoxNomeCurso
            // 
            this.comboBoxNomeCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomeCurso.FormattingEnabled = true;
            this.comboBoxNomeCurso.Location = new System.Drawing.Point(55, 83);
            this.comboBoxNomeCurso.Name = "comboBoxNomeCurso";
            this.comboBoxNomeCurso.Size = new System.Drawing.Size(267, 21);
            this.comboBoxNomeCurso.TabIndex = 3;
            // 
            // btMatricular
            // 
            this.btMatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatricular.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btMatricular.Location = new System.Drawing.Point(12, 149);
            this.btMatricular.Name = "btMatricular";
            this.btMatricular.Size = new System.Drawing.Size(131, 27);
            this.btMatricular.TabIndex = 4;
            this.btMatricular.Text = "Matricular Aluno";
            this.btMatricular.UseVisualStyleBackColor = true;
            this.btMatricular.Click += new System.EventHandler(this.btMatricular_Click);
            // 
            // FormMatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(585, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMatricularAluno";
            this.Text = "MatricularAluno em curso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomeAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMatricular;
        private System.Windows.Forms.ComboBox comboBoxNomeCurso;
        private System.Windows.Forms.Label label2;
    }
}