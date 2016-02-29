namespace Educasfera.Formularios
{
    partial class FormCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtrai = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.btZerar = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.ForeColor = System.Drawing.Color.Blue;
            this.txtVisor.Location = new System.Drawing.Point(0, 0);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(259, 47);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(12, 213);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(116, 32);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 177);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(55, 30);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(73, 177);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(55, 30);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(134, 177);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(55, 30);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 137);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(55, 30);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(73, 137);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(55, 30);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(134, 137);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(55, 30);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 101);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(55, 30);
            this.bt7.TabIndex = 8;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(73, 101);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(55, 30);
            this.bt8.TabIndex = 9;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(134, 101);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(55, 30);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(195, 101);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(55, 30);
            this.btSoma.TabIndex = 11;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSubtrai
            // 
            this.btSubtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtrai.Location = new System.Drawing.Point(195, 137);
            this.btSubtrai.Name = "btSubtrai";
            this.btSubtrai.Size = new System.Drawing.Size(55, 30);
            this.btSubtrai.TabIndex = 12;
            this.btSubtrai.Text = "-";
            this.btSubtrai.UseVisualStyleBackColor = true;
            this.btSubtrai.Click += new System.EventHandler(this.btSubtrai_Click);
            // 
            // btDivide
            // 
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivide.Location = new System.Drawing.Point(195, 177);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(55, 30);
            this.btDivide.TabIndex = 13;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btResultado
            // 
            this.btResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultado.Location = new System.Drawing.Point(195, 213);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(55, 30);
            this.btResultado.TabIndex = 14;
            this.btResultado.Text = "=";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // btZerar
            // 
            this.btZerar.Location = new System.Drawing.Point(12, 61);
            this.btZerar.Name = "btZerar";
            this.btZerar.Size = new System.Drawing.Size(177, 34);
            this.btZerar.TabIndex = 15;
            this.btZerar.Text = "CE";
            this.btZerar.UseVisualStyleBackColor = true;
            this.btZerar.Click += new System.EventHandler(this.btZerar_Click);
            // 
            // btPonto
            // 
            this.btPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPonto.Location = new System.Drawing.Point(134, 213);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(55, 30);
            this.btPonto.TabIndex = 16;
            this.btPonto.Text = ",";
            this.btPonto.UseVisualStyleBackColor = true;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplica.Location = new System.Drawing.Point(195, 63);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(55, 30);
            this.btMultiplica.TabIndex = 17;
            this.btMultiplica.Text = "*";
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.btMultiplica_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 248);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btZerar);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btSubtrai);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.txtVisor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSubtrai;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Button btZerar;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button btMultiplica;
    }
}