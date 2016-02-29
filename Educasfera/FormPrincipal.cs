using Educasfera.Classes;
using Educasfera.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #region Menu item sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saida();
        }
        #endregion

        #region Abre tela cadastro de cursos
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarCursos fcc = new FormCadastrarCursos();            
            fcc.ShowDialog();

        }
        #endregion


        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarAlunos fca = new FormCadastrarAlunos();
            fca.ShowDialog();
        }
        /*----- abre tela Matricular aluno -----------*/
        private void matricularAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatricularAluno fma = new FormMatricularAluno();
            fma.ShowDialog();
        }

        private void alunosMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioAlunosMatriculados fram = new FormRelatorioAlunosMatriculados();
            fram.ShowDialog();
        }

        private void Saida()
        {
            DialogResult dr = MessageBox.Show("Realmente deseja sair ?", " Educasfera",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void anotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBlocoNotas frmbn = new FormBlocoNotas();
            frmbn.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Você deseja realmente sair ?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculadora frmcalc = new FormCalculadora();
            frmcalc.Show();

        }
    }
}

