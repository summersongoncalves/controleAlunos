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
   public  class Curso
    {
        private string query;
        private int id;
        private string nome;
        private string descricao;
        private double preco;

        #region gets e sets
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }
        #endregion

        SqlCommand cmd = null;
        private ConexaoDB conn;

        #region Cadastra Curso no banco
        public bool CadastrarCurso(Curso curso)
        {
            conn = new ConexaoDB();
            if (conn.Conectar() == true && CursoExiste(conn, curso) == false)
            {
                try
                {
                    query = "INSERT INTO Educasfera.dbo.Curso ([Nome],[Descricao],[Preco])VALUES(@Nome,@Descricao,@Preco)";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", curso.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", curso.Descricao);
                    cmd.Parameters.AddWithValue("@Preco", curso.Preco);
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

        private bool CursoExiste(ConexaoDB conn, Curso curso)
        {
            try
            {
                string consulta = "SELECT Nome FROM Educasfera.dbo.Curso WHERE Curso.Nome =" + "'" + curso.Nome + "'";
                SqlCommand command = new SqlCommand(consulta, conn.GetConexao());
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
        
        #region Pesquisar Curso
        public Curso PesquisarCurso(Curso curso)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Id ,Nome, Descricao, Preco from Educasfera.dbo.Curso where nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", curso.nome);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            curso.Id = Convert.ToInt32(dataReader[0]);
                            curso.Nome = dataReader[1].ToString();
                            curso.Descricao = dataReader[2].ToString();
                            curso.Preco = Convert.ToDouble(dataReader[3].ToString());
                        }
                        return curso;
                    }
                    else
                    {
                        curso = null;
                        return curso;
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
                curso = null;
                return curso;
            }

        }
        #endregion
        
        #region Editar Curso
        public bool EditarCurso(Curso curso, String nomeAnterior)
        {
            conn = new ConexaoDB();
            if (conn.Conectar() == true && CursoExiste(conn, curso) == false)
            {
                try
                {
                    query = "UPDATE Educasfera.dbo.Curso SET Nome = @Nome, Descricao = @Descricao, Preco = @Preco WHERE Nome = @NomeAnterior";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", curso.Nome);
                    cmd.Parameters.AddWithValue("@Descricao",curso.Descricao);
                    cmd.Parameters.AddWithValue("@Preco", curso.Preco);
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
        
        #region Excluir Curso
        public bool ExcluirCurso(int id)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = "DELETE FROM Educasfera.dbo.Curso WHERE Id = @Id";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Id", id);
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

        public List<string> listaDeCursos()
        {
            conn = new ConexaoDB();
            List<string> cursos = new List<string>();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Nome from Educasfera.dbo.Curso";
                    cmd = new SqlCommand(query, conn.GetConexao());                   
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            cursos.Add(dataReader["Nome"].ToString());
                            
                        }
                        return cursos;
                    }
                    else
                    {
                        cursos = null;
                        return cursos;
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
                cursos = null;
                return cursos;
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
                    query = " SELECT Id from Educasfera.dbo.Curso where Nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", nome);
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

    }
}
