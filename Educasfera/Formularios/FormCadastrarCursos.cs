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
    public partial class FormCadastrarCursos : Form
    {
        #region declaração de constantes para controle de botoes

        private const int CONTROLE_BOTOES_INICIAL          = 1;        
        private const int CONTROLE_BOTOES_POS_PESQUISAR    = 2;        
        private const int CONTROLE_BOTOES_EDITAR           = 3;
        private const int CONTROLE_BOTOES_INICIAR_CADASTRO = 4;
        private const int CONTROLE_BOTOES_CANCELAR         = 5;
        private const int CONTROLE_BOTOES_BLOQUEIO_GERAL   = 6;
        #endregion

        #region constatntes para auxiliar no controle das abas , quando o usuário entra em alguma aba 
        private const string TAB_CADASTRO_CURSOS = "Cadastro de Cursos";
        private const string TAB_CADASTRO_LICOES = "Cadastro de Lições";
        private const string TAB_CADASTRO_ARQUIVOS = "Cadastro de Arquivos";
        #endregion

        public static Licao l;
        public static Curso c;
        private bool estadoBotaoEditar = false; // define se sistema está em estado edição
        private string nomeAnterior;  


        private static object qualtab = null;

        public static object Qualtab
        {
            get
            {
                return qualtab;
            }

            set
            {
                qualtab = value;
            }
        }

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

        public FormCadastrarCursos()
        {
            InitializeComponent();
           
            controleBotoes(CONTROLE_BOTOES_INICIAL);
            tabCadastroCursos.Focus();
            controleTextBox(false);
                                
        }

        #region CONTROLE DE BOTÕES ativa ou desativa de acordo com o botao clicado
        private void controleBotoes(int botao)
        {
            switch (botao)
            {
                case CONTROLE_BOTOES_INICIAL:
                    btCancelar.Enabled        = false;
                    btEditar.Enabled          = false;
                    btExcluir.Enabled         = false;
                    btGravar.Enabled          = false;
                    btIniciarCadastro.Enabled = true;
                    btPesquisar.Enabled       = true;
                    break;                
                case CONTROLE_BOTOES_POS_PESQUISAR:
                    btCancelar.Enabled        = true;
                    btEditar.Enabled          = true;
                    btExcluir.Enabled         = true ;
                    btGravar.Enabled          = false ;
                    btIniciarCadastro.Enabled = false;
                    btPesquisar.Enabled       = true;
                    break;
                case CONTROLE_BOTOES_EDITAR:
                    btCancelar.Enabled        = true;
                    btEditar.Enabled          = false;
                    btExcluir.Enabled         = false;
                    btGravar.Enabled          = true;
                    btIniciarCadastro.Enabled = false;
                    btPesquisar.Enabled       = true;
                    break;
                case CONTROLE_BOTOES_CANCELAR:
                    controleBotoes(CONTROLE_BOTOES_INICIAL);
                    ; break;              
                case CONTROLE_BOTOES_INICIAR_CADASTRO:
                    btCancelar.Enabled        = true ;
                    btEditar.Enabled          = false;
                    btExcluir.Enabled         = false;
                    btGravar.Enabled          = true;
                    btIniciarCadastro.Enabled = false;
                    btPesquisar.Enabled       = true;
                    break;
                case CONTROLE_BOTOES_BLOQUEIO_GERAL:
                    btCancelar.Enabled        = true;
                    btEditar.Enabled          = false;
                    btExcluir.Enabled         = false;
                    btGravar.Enabled          = false;
                    btIniciarCadastro.Enabled = false;
                    btPesquisar.Enabled       = false;
                    break;
            }
        }
        #endregion

        private void habilitaTxtBoxCadastroLicoes(bool habilitado)
        {
            comboBoxCursos.Enabled = habilitado;
            txtNomeLicao.Enabled   = habilitado;
        }

        private void habilitaTxtBoxCadastroArquivo(bool habilitado)
        {
            comboBoxLicao.Enabled       = habilitado;
            btSelecionarArquivo.Enabled = habilitado;
        }

        private void habilitaTxtBoxCadastroCursos(bool habilitado)
        {
            txtNomeCurso.Enabled = habilitado;
            txtPreco.Enabled     = habilitado;
            txtDescricao.Enabled = habilitado;
        }

        private void controleTextBox(object tab,bool habilitado)
        { // normalmente acionado dentro de um click
            if (tab.ToString().Contains(TAB_CADASTRO_CURSOS))
            {                
                habilitaTxtBoxCadastroCursos(true);
                habilitaTxtBoxCadastroArquivo(false);
                habilitaTxtBoxCadastroLicoes(false);
            }
            if (tab.ToString().Contains(TAB_CADASTRO_LICOES))
            {
                habilitaTxtBoxCadastroCursos(false);
                habilitaTxtBoxCadastroArquivo(false);
                habilitaTxtBoxCadastroLicoes(true);
            }
            if (tab.ToString().Contains(TAB_CADASTRO_ARQUIVOS))
            {
                habilitaTxtBoxCadastroCursos(false);
                habilitaTxtBoxCadastroArquivo(true);
                habilitaTxtBoxCadastroLicoes(false);
            }
        }

        private void controleTextBox(bool habilitado)
        {
            txtNomeCurso.Enabled = habilitado;
            txtPreco.Enabled = habilitado;
            txtDescricao.Enabled = habilitado;
            btSelecionarArquivo.Enabled = habilitado;
            comboBoxLicao.Enabled = habilitado;
            txtNomeLicao.Enabled = habilitado;
            comboBoxCursos.Enabled = habilitado;
        }

        #region Eventos ao entrar nos Tabs de cadastro
        private void tabCadastroCursos_Enter(object sender, EventArgs e)
        {
            // Cadastro de Cursos
            Qualtab = sender;
            btPesquisar.Enabled = true;                        
        }

        private void tabCadastroLicoes_Enter(object sender, EventArgs e)
        {
            Qualtab = sender; // Cadastro de Lições
            btPesquisar.Enabled = true;
        }

        private void tabCadastroArquivos_Enter(object sender, EventArgs e)
        {
            Qualtab = sender; // Cadastro de Arquivos
            btPesquisar.Enabled = false;
        }
        #endregion

        #region EVENTOS COM BOTOES 
        private void btIniciarCadastro_Click(object sender, EventArgs e)
        {
            controleTextBox(Qualtab, true);
            controleBotoes(CONTROLE_BOTOES_INICIAR_CADASTRO);
            //    se estiver na Aba de cadastro  de lições ele carrega o combo box
            if (Qualtab.ToString().Contains(TAB_CADASTRO_LICOES))
            {              
                Curso c = new Curso();
                comboBoxCursos.DataSource = c.listaDeCursos();
                if (comboBoxCursos.DataSource != null)
                {
                    comboBoxCursos.DisplayMember = "Nome";                  
                }                    
                else
                {
                    MessageBox.Show("Será necessário cadastrar um Curso antes de associar.");
                    controleTextBox(false);
                    controleBotoes(CONTROLE_BOTOES_INICIAL);
                }
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            c = null; // zerar sempre o objeto curso...
            l = null;
            
            if (Qualtab.ToString().Contains(TAB_CADASTRO_CURSOS))
            {
                FormPesquisaCurso frmpq = new FormPesquisaCurso();
                frmpq.ShowDialog();
                if (c != null)
                {
                    setarTxtPesquisa(Qualtab.ToString());
                    controleBotoes(CONTROLE_BOTOES_POS_PESQUISAR);
                }
            }

            if (Qualtab.ToString().Contains(TAB_CADASTRO_LICOES))
            {
                FormPesquisaLicao frmpl = new FormPesquisaLicao();
                frmpl.ShowDialog();
                if( l != null)
                {
                    setarTxtPesquisa(Qualtab.ToString());
                    controleBotoes(CONTROLE_BOTOES_POS_PESQUISAR);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            estadoBotaoEditar = false;
            limparTodosTextBox();
            controleBotoes(CONTROLE_BOTOES_INICIAL);
            tabCadastroCursos.Focus();
            controleTextBox(false);
            
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            setaNomeAnterior(Qualtab.ToString());                      
            estadoBotaoEditar = true;
            controleTextBox(Qualtab, true);
            controleBotoes(CONTROLE_BOTOES_EDITAR);
            comboBoxCursos.Hide();
            lbComboBoxLicao.Hide();           
        }

        /*-------------------------------------------------------------------------
            a regra é : só pode excluir se houver pesquisa, e sempre que há pesquisa
            a variavel estática terá algum valor podendo ser acessado os dados caso queira 
            utilizar a fução excluir. 
         /*------------------------------------------------------------------------- */
        private void btExcluir_Click(object sender, EventArgs e)
        {
            excluir(Qualtab.ToString());
            controleBotoes(CONTROLE_BOTOES_INICIAL);
            controleTextBox(false);
        }    
    
        private void btGravar_Click(object sender, EventArgs e)
        {
            controleTextBox(Qualtab, true);
            gravar(Qualtab);
            
            // colocar aqui o apos gravar se houver necessidade....
        }
        #endregion


        #region Métodos auxiliares
        private void limparTodosTextBox()
        {
            txtNomeCurso.Text = "";
            txtPreco.Text = "";
            txtDescricao.Text = "";
            comboBoxLicao.Text = "";
            txtNomeLicao.Text = "";
            comboBoxCursos.Text = "";
        }

        private void setarTxtPesquisa(string tab)
        {

            if (tab.Contains(TAB_CADASTRO_CURSOS) && (c != null))
            {
                txtNomeCurso.Text = c.Nome;
                txtPreco.Text = c.Preco.ToString();
                txtDescricao.Text = c.Descricao;
            }
            if (tab.Contains(TAB_CADASTRO_LICOES) && (l != null))
            {
                txtNomeLicao.Text = l.Nome;               
            }
        }

        private void setaNomeAnterior(string tab)
        {
            if (tab.Contains(TAB_CADASTRO_CURSOS))
            {
                NomeAnterior = txtNomeCurso.Text;
            }
            if (tab.Contains(TAB_CADASTRO_LICOES))
            {
                NomeAnterior = txtNomeLicao.Text;
            }
        }

        private void excluir(string tab)
        {           // se o usuario estiver na aba tab de cursos 
            if (tab.Contains(TAB_CADASTRO_CURSOS))
            {
                // caso o usuário confirme é executada função ExcluirCurso
                DialogResult dr = MessageBox.Show("Realmente deseja Apagar este registro ?", " Atenção",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Curso c = new Curso();
                    if (c.ExcluirCurso(FormCadastrarCursos.c.Id))
                    {
                        MessageBox.Show("Registro foi apagado do banco");
                        controleBotoes(CONTROLE_BOTOES_INICIAL);
                        limparTodosTextBox();
                        controleTextBox(false);
                    }
                }
            }

            if (tab.Contains(TAB_CADASTRO_LICOES))
            {
                // caso o usuário confirme é executada função ExcluirCurso
                DialogResult dr = MessageBox.Show("Realmente deseja Apagar este registro ?"+
                    "\nNão havará cursos vinculados a esta lição...", " Educasfera",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Licao l = new Licao();
                    if (l.excluirLicao(FormCadastrarCursos.l.Nome))
                    {
                        MessageBox.Show("Registro foi apagado do banco");
                        controleBotoes(CONTROLE_BOTOES_INICIAL);
                        limparTodosTextBox();
                        controleTextBox(false);
                    }
                }
            }
        }

        private bool validarTextBox(string nomeTab)
        {
            if (nomeTab.Contains(TAB_CADASTRO_CURSOS))
            {
                if ((string.IsNullOrEmpty(txtNomeCurso.Text)) || (string.IsNullOrEmpty(txtPreco.Text)) || (string.IsNullOrEmpty(txtDescricao.Text)))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (nomeTab.Contains(TAB_CADASTRO_LICOES))
            {
                if (string.IsNullOrEmpty(txtNomeLicao.Text)) 
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }           
        }

        /*-----------------------------------------------------
                MÉTODO IMPORTANTE PARA REALIZAR GRAVAÇÃO
                POIS ELE FAZ O FILTRO DE QUAL ABA O USUÁRIO ESTÁ UTILIZANDO
         -----------------------------------------------------   */
        private void gravar(object tab)
        {
           string nomeTab = tab.ToString();

            #region  usuario na tab de cadastro de cursos
            /*-----------------------------------------------------
                CASO O USUARIO ESTIVER NA TAB DE CADASTRO DE CURSOS 
                REALIZA OPERAÇÃO DE REGISTRO NO BANCO
            -----------------------------------------------------*/
            if (nomeTab.Contains(TAB_CADASTRO_CURSOS))
            {
                if (estadoBotaoEditar)
                {   // codigo para edição
                    if (validarTextBox(nomeTab))
                    {
                        Curso curso = new Curso();
                        curso.Nome = txtNomeCurso.Text.ToUpper();
                        curso.Descricao = txtDescricao.Text;
                        curso.Preco = Convert.ToDouble(txtPreco.Text);
                        if (curso.EditarCurso(curso, NomeAnterior))
                        {
                            MessageBox.Show("Edição realizada com sucesso!", "Informação");
                            limparTodosTextBox();
                            controleBotoes(CONTROLE_BOTOES_INICIAL);
                            controleTextBox(false);
                        }
                        else
                        {
                            MessageBox.Show("Curso já registrado tente outro nome", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso");
                    }
                    FormCadastrarCursos.c = null;
                }
                else // se o estado do botão for false então será a realizada a Primeira gravação
                {
                    if (validarTextBox(nomeTab))
                    {
                        Curso curso = new Curso();
                        curso.Nome = txtNomeCurso.Text.ToUpper();
                        curso.Preco = Convert.ToDouble(txtPreco.Text.ToString());
                        curso.Descricao = txtDescricao.Text.ToUpper();
                        if (curso.CadastrarCurso(curso))
                        {
                            MessageBox.Show("Cadastrado com sucesso", "");
                            limparTodosTextBox();
                            controleBotoes(CONTROLE_BOTOES_INICIAL);
                            controleTextBox(false);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao conectar com Banco ou Nome já registrado favor utilizar a Pesquisa", "Erro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso");
                    }
                }
            }
            #endregion

            /* -----------------------------------------------------
                CASO O USUARIO ESTIVER NA TAB DE CADASTRO DE LIÇÕES
                REALIZA OPERAÇÃO DE REGISTRO NO BANCO
            *----------------------------------------------------*/
            #region usuário na tab de cadastro de lições
            if (nomeTab.Contains(TAB_CADASTRO_LICOES))
            {
                if (estadoBotaoEditar)
                {   // codigo para edição
                    if (validarTextBox(nomeTab))
                    {
                        Licao licao = new Licao();
                        licao.Nome = txtNomeLicao.Text.ToUpper();                                                
                        if (licao.editarLicao(licao, NomeAnterior))
                        {
                            MessageBox.Show("Edição realizada com sucesso!", "Informação");
                            limparTodosTextBox();
                            controleBotoes(CONTROLE_BOTOES_INICIAL);
                            controleTextBox(false);
                        }
                        else
                        {
                            MessageBox.Show("Lição já registrada tente outro nome", "Aviso");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso");
                    }
                    FormCadastrarCursos.l = null;
                }
            else {
                if (validarTextBox(nomeTab))
                {
                    Licao licao = new Licao();
                    licao.Nome = txtNomeLicao.Text.ToUpper();
                    licao.IdCurso = licao.getIdCurso(comboBoxCursos.Text); // falta fazer a função que retorna o id do curso referente                                                         
                    if (licao.cadastrarLicao(licao))
                    {
                        MessageBox.Show("Cadastrado com sucesso", "");
                        limparTodosTextBox();
                        controleBotoes(CONTROLE_BOTOES_INICIAL);
                        controleTextBox(false);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar ou esta lição já está vinculada \n a este curso.", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor preencha todos os campos", "Aviso");
                }
            }
            }
            #endregion

            if (nomeTab.Contains(TAB_CADASTRO_ARQUIVOS))
            {

            }
        }





        #endregion

       

        private void btIniciarCadastro_Enter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Iniciar Cadastro", btIniciarCadastro);
        }
    }
}
