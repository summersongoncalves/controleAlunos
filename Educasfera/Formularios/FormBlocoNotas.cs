using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educasfera.Formularios
{
    public partial class FormBlocoNotas : Form
    {
        #region variaveis
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private static bool alterado; // variavel que irá detectar alterações no bloco de notas.
        #endregion

        #region Gets e Sets da variavel Alterado
        public static bool Alterado
        {
            get
            {
                return alterado;
            }

            set
            {
                alterado = value;
            }
        }
        #endregion


        public FormBlocoNotas()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Arial", 12);
            Alterado = false;  
        }

        #region menu Item abrir ...
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Abrir...";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Texgto (*.txt) | *.txt";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
                    richTextBox1.Tag = null;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao Abrir : " + err, "Aviso");
                }
            }
            Alterado = false;
        }
        #endregion

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvarDocumento();           
        }

        #region Método salvarDocumento
        private void salvarDocumento()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar...";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Ficheiros de texto (*.txt) | *.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    richTextBox1.Tag = null;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao salvar : " + err, "Aviso");
                }
            }
            Alterado = false;
        }
        #endregion

        #region MenuItem sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Alterado)
            {
                DialogResult res;
                res = MessageBox.Show("Houve alteração no documento, deseja Salvar ?", "Editor de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    salvarDocumento();
            }
            this.Close();
        }
        #endregion

        #region método altera variável Alterado para true caso haja alteração no textBox
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Alterado = true;
        }
        #endregion

        #region evento ao clicar no 'x' para sair.
        private void FormBlocoNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Você deseja realmente sair ?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }          
        }
        #endregion
    }
}
