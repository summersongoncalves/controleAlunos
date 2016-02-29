using Educasfera.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera.Formularios
{
    public partial class FormPesquisaCurso : Form
    {
        public FormPesquisaCurso()
        {
            InitializeComponent();
        }
        private void btPesquisar_Click(object sender, EventArgs e)
        {    
            Curso curso = new Curso();
            curso.Nome = txtNomeCurso.Text.ToUpper();
            curso = curso.PesquisarCurso(curso);
            if (curso == null)
            {
                MessageBox.Show("Nome do Curso Não está  cadastrado, tente outro nome.", "Aviso");
                curso = null;
            }
            else
            {
                MessageBox.Show("Registro Localizado", "Aviso");
                FormCadastrarCursos.c = curso;
                Dispose();
            }
        }
    }
    
}
