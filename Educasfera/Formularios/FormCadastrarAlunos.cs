using Educasfera.Classes;
using System;
using System.Collections;
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
    public partial class FormCadastrarAlunos : Form
    {
        private string tipoForm; // assumirá valores >> cadastrar , editar,
        public static Aluno a;    // variável estática recebe valor ao sair do formulário de busca.
        private string nomeAnterior;
        

        public string NomeAnterior
        {
            get
            {
                return nomeAnterior;
            }

            set
            {
                nomeAnterior = value;
            }
        }

        public FormCadastrarAlunos()
        {
            InitializeComponent();           

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar(object sender, EventArgs e)
        {
            CadastrarAluno();
        }

        #region   Método  Cadastrar Alunos 
        public void CadastrarAluno()
        {
            tipoForm = "cadastrar";
            // esta condição verifica se está sendo editado um cadastro ou registrando pela primeira vez
            if (btEditar.Enabled == true) 
            {                
                Aluno aluno = new Aluno();
                aluno.Nome = txtNome.Text.ToUpper();
                aluno.Data = dataNasc.Text;
                if (aluno.EditarAluno(aluno,NomeAnterior))
                {
                    MessageBox.Show("Edição realizada com sucesso!", "Informação");
                    LimparCampos(tipoForm);
                    HabilitaDesabilitaBotoes("inicio");
                    HabilitaDesabilitaTxt(false);
                }
                else
                {
                    MessageBox.Show("Aluno já registrado tente outro nome", "Aviso");
                }
                FormCadastrarAlunos.a = null;
            }
            // caso não editando um registro ele insere a gravanção pela primeira vez
            else
            {                
                Aluno aluno = new Aluno();
                aluno.Nome = txtNome.Text.ToUpper();
                aluno.Data = dataNasc.Text;
                if (Validar())
                {
                    if (aluno.CadastrarAluno(aluno))
                    {
                        MessageBox.Show("Cadastrado com sucesso", "");
                        LimparCampos(tipoForm);
                        HabilitaDesabilitaBotoes("inicio");
                        HabilitaDesabilitaTxt(false);
                    }
                    else
                    {
                        MessageBox.Show("Não pode ser Cadatrado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Favor, preencha todos os campos...");
                }
            }           
        }
        #endregion

        #region Limpar Campos
        public void LimparCampos(string tipo)
        {
            switch(tipo)
            {
                case "cadastrar":
                    txtNome.Text = "";
                    dataNasc.Text = "";
                    break;
                case "editar":
                    HabilitaDesabilitaTxt(true);
                    break;               
            }            
        }
        #endregion

        #region Valida campos
        public bool Validar()
        {
            if ((string.IsNullOrEmpty(txtNome.Text)) || (string.IsNullOrEmpty(dataNasc.Text)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Pesquisa aluno_Click
        private void pesquisarAluno_Click(object sender, EventArgs e)
        {
            a = null; // zera objeto 'a' referente a aluno 
            FormPesquisaAluno  frmpa = new FormPesquisaAluno();
            frmpa.ShowDialog();
            setarTxtPesquisa();
            HabilitaDesabilitaBotoes("pos-pesquisa");            
        }
        #endregion

        #region Método utilizado para exibir os dados obtidos pela classe FormPesquisaAluno
        public void setarTxtPesquisa()
        {
            if (FormCadastrarAlunos.a != null)
            {
                txtNome.Text = FormCadastrarAlunos.a.Nome;
                dataNasc.Text = FormCadastrarAlunos.a.Data;
                HabilitaDesabilitaTxt(false);
            }
        }
        #endregion

        private void FormCadastrarAlunos_Load(object sender, EventArgs e)
        {
            HabilitaDesabilitaBotoes("inicio");
            HabilitaDesabilitaTxt(false);
           
        }

        private void btLiberarCadastro_Click(object sender, EventArgs e)
        {            
            HabilitaDesabilitaBotoes("liberar cadastro");
            HabilitaDesabilitaTxt(true);
            LimparCampos("cadastrar");

        }

        #region Método para habilitar e desabilitar botoes
        private void HabilitaDesabilitaBotoes(string bt)
        {
            switch (bt)
            {
                case "inicio":
                    btGravar.Enabled = false;
                    btExcluir.Enabled = false;
                    btPesquisar.Enabled = true;
                    btLiberarCadastro.Enabled = true;
                    btEditar.Enabled = false;
                    break;
                case "liberar cadastro":
                    btGravar.Enabled = true;
                    btLiberarCadastro.Enabled = false;
                    btPesquisar.Enabled = false;
                    btEditar.Enabled = false;                                 
                    break;
                case "cancelar":
                    btGravar.Enabled = false;
                    btExcluir.Enabled = false;
                    btPesquisar.Enabled = true;
                    btLiberarCadastro.Enabled = true;                   
                    break;
                case "pos-pesquisa":
                    btGravar.Enabled = false;
                    btExcluir.Enabled = true;
                    btPesquisar.Enabled = true;
                    btLiberarCadastro.Enabled = false;
                    btEditar.Enabled = true;
                    break;
                case "editar" :
                    btGravar.Enabled = true;
                    btExcluir.Enabled = false;
                    btPesquisar.Enabled = true;
                    btLiberarCadastro.Enabled = false;
                    btEditar.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Método para habilitar e desabilitar textBox
        private void HabilitaDesabilitaTxt(bool a)
        {
            if (a)
            {
                txtNome.Enabled = true;
                dataNasc.Enabled = true;
            }
            else
            { 
                txtNome.Enabled = false;
                dataNasc.Enabled = false;               
            }
        }
        #endregion

        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaBotoes("inicio");
            HabilitaDesabilitaTxt(false);
            LimparCampos("cadastrar");          
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
         
            NomeAnterior = txtNome.Text;
            HabilitaDesabilitaBotoes("editar");
            HabilitaDesabilitaTxt(true);
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
         // caso o usuário confirme é executada função ExcluirAluno
            DialogResult dr = MessageBox.Show("Realmente deseja Apagar este registro ?", " Educasfera",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Aluno a = new Aluno();
                if (a.ExcluirAluno(FormCadastrarAlunos.a.Id))
                {
                    MessageBox.Show("Registro foi apagado do banco");
                    HabilitaDesabilitaBotoes("inicio");
                    LimparCampos("cadastrar");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query;
            SqlCommand cmd = null;
            ConexaoDB conn;
            conn = new ConexaoDB();
            if (conn.Conectar())
            {
                try
                {   // faz a contulta e retorna em ordem crescente A-Z
                    query = "select Aluno.Id as Codigo , Aluno.Nome from Educasfera.dbo.Aluno Order BY Nome asc";
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

    }// fim da classe FormCadastrarAlunos
}

