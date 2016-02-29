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
    public partial class FormPesquisaLicao : Form
    {
        public FormPesquisaLicao()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Licao licao = new Licao();
            licao.Nome = txtNomeLicao.Text.ToUpper();
            licao = licao.pesquisarLicao(licao);
            if (licao == null)
            {
                MessageBox.Show("Nome da Lição Não está cadastrado, tente outro nome.", "Aviso");
                licao = null;
            }
            else
            {
                MessageBox.Show("Registro Localizado", "Aviso");
                FormCadastrarCursos.l = licao;     // aqui passa o valor para a estatica no formulario
                Dispose();
            }
        }
    }
}
