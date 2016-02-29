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
    public partial class FormCalculadora : Form
    {
        StringBuilder strMontaValor;
        double resultadoTemporario;
        double valor1;
        string operacaoAnterior = "";

        #region Mapeamento para os eventos de teclas
        private enum ASCIIKey
        {
            Key0 = 0x30, Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9,
            KeyA = 0x41, KeyB, KeyC, KeyD, KeyE, KeyF,
            Keya = 0x61, Keyb, Keyc, Keyd, Keye, Keyf,
            KeyDecimal = 0x2E, KeyAdd = 0x2B, KeySubtract = 0x2D, KeyMultiply = 0x2A, KeyDivide = 0x2F,
            KeyBackspace = 0x08
        };
        #endregion       

        public FormCalculadora()
        {
            InitializeComponent();
            iniciarControles();
        }

        private void iniciarControles()
        {
            txtVisor.BackColor = Color.White;
            txtVisor.Text = "0";
            strMontaValor = new StringBuilder();
        }

        #region Controladora das teclas pressionadas
        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((ASCIIKey)e.KeyChar)
            {
                case ASCIIKey.Key0: bt0.PerformClick(); break;
                case ASCIIKey.Key1: bt1.PerformClick(); break;
                case ASCIIKey.Key2: bt2.PerformClick(); break;
                case ASCIIKey.Key3: bt3.PerformClick(); break;
                case ASCIIKey.Key4: bt4.PerformClick(); break;
                case ASCIIKey.Key5: bt5.PerformClick(); break;
                case ASCIIKey.Key6: bt6.PerformClick(); break;
                case ASCIIKey.Key7: bt7.PerformClick(); break;
                case ASCIIKey.Key8: bt8.PerformClick(); break;
                case ASCIIKey.Key9: bt9.PerformClick(); break;
                case ASCIIKey.KeyDecimal: btPonto.PerformClick(); break;
                case ASCIIKey.KeyAdd: btSoma.PerformClick(); break;
                case ASCIIKey.KeySubtract: btSubtrai.PerformClick(); break;
                case ASCIIKey.KeyMultiply: btMultiplica.PerformClick(); break;
                case ASCIIKey.KeyDivide: btDivide.PerformClick(); break;
                case ASCIIKey.KeyBackspace: btZerar.PerformClick(); break;
            };
        }


        #endregion

        #region setaVisor - monta a string de numeros no visor
        private void setaVisor(String numero, int indice)
        {
            strMontaValor.Append(numero);
            txtVisor.Text = strMontaValor.ToString();
        }
        #endregion 
        public void setaVisor(double resultado)
        {
            strMontaValor.Append(resultado.ToString());
        }

        #region Eventos gerados pelo click de 0 a 9 e ','
        private void bt1_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("1");

            setaVisor("1", indice);
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("0");
            if (!txtVisor.Text.Equals("0"))
            {
                setaVisor("0", indice);
            }
        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf(",");
            // se na string não tem ponto (não é decimal) e não começa com 0 : exemplo 23 aí ele insere o ponto
            if ((!txtVisor.Text.Contains(",")) && (!txtVisor.Text.StartsWith("0")))
            {
                setaVisor(",", indice);
            }
            // se começa com 0 e é apenas 0 então ele insere '0,'
            if ((txtVisor.Text.StartsWith("0")) && (txtVisor.Text.Length == 1))
            {
                txtVisor.Text = "0,";//
                strMontaValor.Append("0,"); //
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("2");
            setaVisor("2", indice);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("3");
            setaVisor("3", indice);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("4");
            setaVisor("4", indice);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("5");
            setaVisor("5", indice);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("6");
            setaVisor("6", indice);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("7");
            setaVisor("7", indice);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("8");
            setaVisor("8", indice);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            int indice = sender.ToString().IndexOf("9");
            setaVisor("9", indice);
        }
        #endregion

        private void btZerar_Click(object sender, EventArgs e)
        {
            zeraIniciaStrMontaValor();
            resultadoTemporario = 0;
            valor1 = 0;           
            txtVisor.Text = "0";
            operacaoAnterior = "";
        }

        private void zeraIniciaStrMontaValor()
        {
            strMontaValor = null;
            strMontaValor = new StringBuilder();
        }

        #region Eventos gerados pelo click dos botões  + , - , / , *
        private void btSoma_Click(object sender, EventArgs e)
        {

            //se no visor não tiver 0 ou '0,' ele executa operação
            if (!txtVisor.Text.Equals("0") && !txtVisor.Text.Equals("0,"))
            {
                if (resultadoTemporario == 0)
                {
                    resultadoTemporario = Convert.ToDouble(txtVisor.Text.ToString());
                }
                else
                {
                    valor1 = Convert.ToDouble(txtVisor.Text.ToString());
                    if (operacaoAnterior != "")
                    {
                        executaOperacaoAnterior(operacaoAnterior);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }
                    else
                    {
                        resultadoTemporario = somar(valor1);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }

                }
                zeraIniciaStrMontaValor();
                operacaoAnterior = "+";
            }
        }
        #endregion

        private void executaOperacaoAnterior(string operacao)
        {
            switch (operacao)
            {
                case "+": resultadoTemporario = somar(valor1); break;
                case "-": resultadoTemporario = subtrair(valor1); break;
                case "/": resultadoTemporario = dividir(valor1); break;
                case "*": resultadoTemporario = multiplicar(valor1); break;
            };
        }
        
        #region as 4 operações
        public double somar(double valor)
        {
            resultadoTemporario += valor;
            return resultadoTemporario;
        }
        public double subtrair(double valor)
        {
            resultadoTemporario -= valor;
            return resultadoTemporario;
        }
        public double dividir(double valor)
        {
            resultadoTemporario /= valor;
            return resultadoTemporario;
        }
        public double multiplicar(double valor)
        {
            resultadoTemporario *= valor;
            return resultadoTemporario;
        }
        #endregion

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            //se no visor não tiver 0 ou '0,' ele executa operação
            if (!txtVisor.Text.Equals("0") && !txtVisor.Text.Equals("0,"))
            {
                if (resultadoTemporario == 0)
                {
                    resultadoTemporario = Convert.ToDouble(txtVisor.Text.ToString());
                }
                else
                {
                    valor1 = Convert.ToDouble(txtVisor.Text.ToString());
                    if (operacaoAnterior != "")
                    {
                        executaOperacaoAnterior(operacaoAnterior);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }
                    else
                    {
                        resultadoTemporario = multiplicar(valor1);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }

                }
                zeraIniciaStrMontaValor();
                operacaoAnterior = "*";
            }
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            //se no visor não tiver 0 ou '0,' ele executa operação
            if (!txtVisor.Text.Equals("0") && !txtVisor.Text.Equals("0,"))
            {
                if (resultadoTemporario == 0)
                {
                    resultadoTemporario = Convert.ToDouble(txtVisor.Text.ToString());
                }
                else
                {
                    valor1 = Convert.ToDouble(txtVisor.Text.ToString());
                    if (operacaoAnterior != "")
                    {
                        executaOperacaoAnterior(operacaoAnterior);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }
                    else
                    {
                        resultadoTemporario = subtrair(valor1);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }

                }
                zeraIniciaStrMontaValor();
                operacaoAnterior = "-";
            }
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            //se no visor não tiver 0 ou '0,' ele executa operação
            if (!txtVisor.Text.Equals("0") && !txtVisor.Text.Equals("0,"))
            {
                if (resultadoTemporario == 0)
                {
                    resultadoTemporario = Convert.ToDouble(txtVisor.Text.ToString());
                }
                else
                {
                    valor1 = Convert.ToDouble(txtVisor.Text.ToString());
                    if (operacaoAnterior != "")
                    {
                        executaOperacaoAnterior(operacaoAnterior);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }
                    else
                    {
                        resultadoTemporario = dividir(valor1);
                        txtVisor.Text = resultadoTemporario.ToString();
                    }

                }
                zeraIniciaStrMontaValor();
                operacaoAnterior = "/";
            }
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            if (operacaoAnterior != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text.ToString());
                executaOperacaoAnterior(operacaoAnterior);
                txtVisor.Text = resultadoTemporario.ToString();               
                zeraIniciaStrMontaValor();
                resultadoTemporario = 0;
                valor1 = 0;
                operacaoAnterior = "";
            }            

        }
    }
}
