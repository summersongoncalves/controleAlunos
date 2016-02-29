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
using System.Collections;

namespace Educasfera.Formularios
{
    public partial class FormMatricularAluno : Form
    {

        private Aluno aluno;
        private Curso curso;
       
        public FormMatricularAluno()
        {
            InitializeComponent();
            carregarListaAlunos();
            carregarListaCursos();
        }
        private void carregarListaAlunos()
        {
            aluno = new Aluno();
            comboBoxNomeAluno.DataSource = aluno.listaDeAlunosNaoMatriculados();
            if (comboBoxNomeAluno.DataSource != null)
            {
                comboBoxNomeAluno.DisplayMember = "Nome";
            }
            else
            {
                MessageBox.Show("Será necessário cadastrar um Aluno antes de Matricular.");
            }
        }    
        private void carregarListaCursos()
        {
            curso = new Curso();           
            comboBoxNomeCurso.DataSource = curso.listaDeCursos();
            if (comboBoxNomeCurso.DataSource != null)
            {
                comboBoxNomeCurso.DisplayMember = "Nome";
            }
            else
            {
                MessageBox.Show("Será necessário cadastrar um Curso antes de Matricular.");
            }
        }

        private void btMatricular_Click(object sender, EventArgs e)
        {// se o aluno já estiver matriculado ele não deve aparecer no combo box
         // porém os cursos podem aparecer sempre...         
            aluno.Nome = comboBoxNomeAluno.Text;
            curso.Nome = comboBoxNomeCurso.Text;
            curso.Id = curso.buscaId(curso.Nome);
            aluno.Id = aluno.buscaId(aluno.Nome);            
            if (aluno.matricularAluno(aluno, curso))
            {
                MessageBox.Show("Aluno Matriculado");
                carregarListaAlunos();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar matrícula");
            }
                          
            

        }
    }
    
}
