using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera.Classes
{
    public class Aluno
    {

        SqlCommand cmd = null;
        private ConexaoDB conn;
        private string query;
        private string nome;
        private int id;
        private int idCurso;
        private string data;
        private int idMatricula;

        #region Métodos get and set
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdCurso
        {
            get
            {
                return idCurso;
            }

            set
            {
                idCurso = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int IdMatricula
        {
            get
            {
                return idMatricula;
            }

            set
            {
                idMatricula = value;
            }
        }

        #endregion

        #region Cadastra aluno no banco
        public bool CadastrarAluno(Aluno aluno)
        {
            conn = new ConexaoDB();

            if (conn.Conectar() == true && NomeExiste(conn, aluno) == false)
            {

                try
                {
                    query = "INSERT INTO Educasfera.dbo.Aluno ([Nome],[DataNascimento])VALUES(@Nome,@DataNascimento)";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", aluno.nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", aluno.data);
                    cmd.ExecuteNonQuery();
                    return true;
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
                return false;
            }
        }
        #endregion

        #region Consulta se o nome existe no banco
        private bool NomeExiste(ConexaoDB c, Aluno a)
        {
            try
            {
                string consulta = "SELECT Nome FROM Educasfera.dbo.Aluno WHERE Aluno.Nome =" + "'" + a.Nome + "'";
                SqlCommand command = new SqlCommand(consulta, c.GetConexao());
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    return true; ;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro: " + e, "Aviso");
                return true;
            }
        }
        #endregion

        #region Pesquisar Aluno
        public Aluno PesquisarAluno(Aluno aluno)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Id ,Nome, DataNascimento from Educasfera.dbo.Aluno where nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", aluno.nome);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            aluno.Id = Convert.ToInt32(dataReader[0]);
                            aluno.Nome = dataReader[1].ToString();
                            aluno.Data = dataReader[2].ToString();
                        }
                        return aluno;
                    }
                    else
                    {
                        aluno = null;
                        return aluno;
                    }
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
                aluno = null;
                return aluno;
            }

        }
        #endregion

        #region Editar Aluno
        public bool EditarAluno(Aluno aluno, String nomeAnterior)
        {
            conn = new ConexaoDB();
            if (conn.Conectar() == true && NomeExiste(conn, aluno) == false)
            {
                try
                {
                    query = "UPDATE Educasfera.dbo.Aluno SET Nome = @Nome, DataNascimento = @DataNascimento WHERE Nome = @NomeAnterior";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", aluno.nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", aluno.data);
                    cmd.Parameters.AddWithValue("@NomeAnterior", nomeAnterior);
                    cmd.ExecuteNonQuery();
                    return true;
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
                return false;
            }
        }
        #endregion

        #region Excluir Aluno
        public bool ExcluirAluno(int id)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = "DELETE FROM Educasfera.dbo.Aluno WHERE Id = @Id";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException sqlerr)
                {
                    MessageBox.Show("Aluno está matriculado em algum curso,Não é possivel excluir", "Aviso");
                    return false;
                }
                finally
                {
                    conn.Desconectar();
                }
            }
            else // senão não é possível conectar e retorna false
            {
                return false;
            }
        }
        #endregion

        public bool matricularAluno(Aluno aluno, Curso curso)
        {
            conn = new ConexaoDB();
            if (conn.Conectar() == true)
            {
                try
                {
                    query = "INSERT INTO Educasfera.dbo.Matricula ([Id_Aluno],[Id_Curso])VALUES(@Id_Aluno,@Id_Curso)";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Id_Aluno", aluno.Id);
                    cmd.Parameters.AddWithValue("@Id_Curso", curso.Id);                    
                    cmd.ExecuteNonQuery();
                    return true;
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
                return false;
            }
        }

        public List<string> listaDeAlunos()
        {
            conn = new ConexaoDB();
            List<string> alunos = new List<string>();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Aluno.Nome from Educasfera.dbo.Aluno, Educasfera.dbo.Matricula where Aluno.Id <> Matricula.Id_Aluno ";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            alunos.Add(dataReader["Nome"].ToString());

                        }
                        return alunos;
                    }
                    else
                    {
                        alunos = null;
                        return alunos;
                    }
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
                alunos = null;
                return alunos;
            }
        }

        public List<string> listaDeAlunosNaoMatriculados()
        {
            conn = new ConexaoDB();
            List<string> alunos = new List<string>();
            if (conn.Conectar())
            {
                try
                {
                    query = "select Nome from Educasfera.dbo.Aluno where not exists(select Id from Educasfera.dbo.Matricula where Aluno.Id = Matricula.Id_Aluno)";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            alunos.Add(dataReader["Nome"].ToString());

                        }
                        return alunos;
                    }
                    else
                    {
                        alunos = null;
                        return alunos;
                    }
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
                alunos = null;
                return alunos;
            }
        }

        public int buscaId(string nome)
        {
            int id = 0;
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Id from Educasfera.dbo.Aluno where Nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome",nome);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                           id = Convert.ToInt32(dataReader[0]);                           
                        }
                        return id;
                    }
                    else
                    {                       
                        return id;
                    }
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
                return id;
            }
           
        }
            
    } // fim classe Aluno
}//fim name space

