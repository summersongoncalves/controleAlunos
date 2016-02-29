using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera.Classes
{
    public class Licao
    {
        private int id;
        private int idCurso;
        private string nome;
        SqlCommand cmd = null;
        private ConexaoDB conn;
        private string query;

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

        public int getIdCurso(string curso)
        {
            int id = 0;
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {                    
                    query = "SELECT Id  from Educasfera.dbo.Curso where nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", curso);
                    SqlDataReader dataReader = cmd.ExecuteReader();                    
                    while (dataReader.Read())
                    {
                        id = Convert.ToInt32(dataReader[0]);                            
                    }
                    return id;             
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
            else // senão não é possível conectar
            {
                MessageBox.Show("Não foi possível conectar","Aviso");
                return  id;
            }
        }

        public bool cadastrarLicao(Licao licao)
        {
            conn = new ConexaoDB();
            if ((conn.Conectar() == true )&& (verificaDuplicidadeLicao(conn, licao)) == false)
            {
                try
                {
                    query = "INSERT INTO Educasfera.dbo.Licao ([Id_curso],[Nome])VALUES(@Id_curso,@Nome)";
                    cmd = new SqlCommand(query, conn.GetConexao());                   
                    cmd.Parameters.AddWithValue("@Id_curso", licao.IdCurso);
                    cmd.Parameters.AddWithValue("@Nome", licao.Nome);                    
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

        private bool verificaDuplicidadeLicao(ConexaoDB conn, Licao licao)
        {
            try
            {
                string consulta = "select * from Educasfera.dbo.Licao where Nome = @Nome AND Id_curso = @Id_curso";
                SqlCommand command = new SqlCommand(consulta, conn.GetConexao());
                command.Parameters.AddWithValue("@Nome", licao.Nome);
                command.Parameters.AddWithValue("Id_curso",licao.IdCurso);
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

        public Licao pesquisarLicao(Licao licao)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = " SELECT Id ,Id_curso, Nome from Educasfera.dbo.Licao where nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", licao.Nome);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            licao.Id = Convert.ToInt32(dataReader[1]);
                            licao.Nome = dataReader[2].ToString();                           
                        }
                        return licao;
                    }
                    else
                    {
                        licao = null;
                        return licao;
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
                licao = null;
                return licao;
            }
        }
        public bool licaoExiste(ConexaoDB conn, Licao licao)
        {
            try
            {
                string consulta = "SELECT Nome FROM Educasfera.dbo.Licao WHERE Licao.Nome =" + "'" + licao.Nome + "'";
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
        public bool editarLicao(Licao licao, string nomeAnterior)
        {
            conn = new ConexaoDB();
            if (conn.Conectar() == true && licaoExiste(conn, licao) == false)
            {
                try
                {
                    query = "UPDATE Educasfera.dbo.Licao SET Nome = @Nome WHERE Nome = @NomeAnterior";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", licao.Nome);
                    cmd.Parameters.AddWithValue("@NomeAnterior",nomeAnterior );
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
        public bool excluirLicao(string nome)
        {
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {
                    query = "DELETE FROM Educasfera.dbo.Licao WHERE Nome = @Nome";
                    cmd = new SqlCommand(query, conn.GetConexao());
                    cmd.Parameters.AddWithValue("@Nome", nome);
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
        
    }
}
