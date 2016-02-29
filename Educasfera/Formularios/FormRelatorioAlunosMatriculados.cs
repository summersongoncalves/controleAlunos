using Educasfera.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera.Formularios
{
    public partial class FormRelatorioAlunosMatriculados : Form
    {
        public FormRelatorioAlunosMatriculados()
        {
            InitializeComponent();
        }

        private void btCarregarLista_Click(object sender, EventArgs e)
        {
            string query;
            SqlCommand cmd = null;
            ConexaoDB conn;
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {   // faz a contulta e retorna em ordem crescente A-Z
                    query = "select Matricula.Id As Matricula, Aluno.Nome As Nome, Curso.Nome As Curso from Educasfera.dbo.Matricula, Educasfera.dbo.Aluno,Educasfera.dbo.Curso where Matricula.Id_Aluno = Aluno.Id AND MAtricula.Id_Curso = Curso.Id  Order BY Nome asc";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataAdapter.Update(dataTable);
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    conn.Desconectar();
                }
            }
            else // senão não é possível conectar e retorna false
            {
                MessageBox.Show("Não foi possível conectar", "Aviso");
            }
        }
    }
    
}
