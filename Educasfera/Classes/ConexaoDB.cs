using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;

namespace Educasfera.Classes
{
    public class ConexaoDB
    {
        private string strConnect;
        private string query = string.Empty;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        
       
        public SqlConnection GetConexao()
        {
            if (Conectar()) { return conn; }
            else { return conn = null; }
        }
        #region Realiza conexão com banco
        public bool Conectar()
        {
            strConnect = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;            
            conn = new SqlConnection(strConnect);
            try
            {
                conn.Open();
                return true;
            }
            catch(SqlException e)
            {
                conn = null;
                return false;
            }
        }
        #endregion

        #region Finaliza conexão com banco
        public bool Desconectar()
        {
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            else
            {
                conn.Dispose();
                return false;
            }
        }
        #endregion

        #region Insert no banco
      
          //  if (!VerificarDuplicidade(arrayInsert[0]))
         //   {
              // fim do verificarDuplicidade()
          /*  else
            {
                MessageBox.Show("Já existe este nome registrado.", "");
                return false;
            }
        }*/
        #endregion

        #region Verifica duplicidade de dado Nome
        /*  public bool VerificarDuplicidade(ArrayList nome)
          {
              query = "SELECT Nome FROM Aluno WHERE Nome = 'Joao Paulo';";
              if (this.Conectar())
              {
                  try
                  {
                      if(cmd.execitereader)
                      return true;
                  }
                  catch (SqlException sqlerr)
                  {
                      throw sqlerr;
                  }
                  finally
                  {
                      this.Desconectar();
                  }
              }
              else
              {
                  return false;
              }
          }*/
        #endregion
    }

}
