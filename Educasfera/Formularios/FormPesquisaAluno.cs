using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Educasfera.Classes;


namespace Educasfera.Formularios
{
    public partial class FormPesquisaAluno : Form
    {
       
        public FormPesquisaAluno()
        {
            InitializeComponent();
        }

        private void btPesquisarAluno(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text.ToUpper();
            aluno = aluno.PesquisarAluno(aluno);
            if(aluno == null)
            {
                MessageBox.Show("Nome Não está cadastrado, tente outro nome.", "Aviso");
            }
            else
            {
                MessageBox.Show("Registro Localizado", "Aviso");
                FormCadastrarAlunos.a = aluno;              
                Dispose();
            }
        }
    }
}
