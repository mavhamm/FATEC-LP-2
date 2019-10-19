using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBegin
{
    public partial class ex38 : Form
    {
        public ex38()
        {
            InitializeComponent();
        }

        private void btnCalcularH_Click(object sender, EventArgs e)
        {
            double n, h = 0;

            if (!double.TryParse(txtBoxNum.Text, out n))
            {
                MessageBox.Show("Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNum.Text = "";
            }
            else
            {
                if (n <= 0 || n > 50)
                {
                    MessageBox.Show("Número deve ser maior que 0 e menor que 50.");
                    txtBoxNum.Text = "";
                    txtBoxNum.Focus();
                    return;
                }
                    
                for (int i = 1; i <= n; i++)
                {
                    h += 1.0 / i;
                }

                MessageBox.Show("H = " + h.ToString("N3"), "Sucesso!");
            }
            txtBoxNum.Focus();
        }

        /*                   Passo-a-passo para habilitar o teclado como modo de input para o usuário 
        *      
        *      1. KeyPreview = True | Em frmCalcWindows.cs [Design] > Propriedades da janela do programa > mudar KeyPreview para True.
        *      2. Criar private void KeyPress {} referenciado | Em Eventos (raínho ao lado de Propriedades), duplo clique em KeyPress.
        *      3. Digitar o código. No caso abaixo usamos switch case. A lógica é: para cada tecla pressionada, 
        *           redirecionamos a ação para o clique do botão, e.g.:
        *           O usuário digitando o número 1, é ativado o código do botão do número 1, como se o btn1 tivesse 
        *           sido clicado (btn1.PerformClick()), reutilizando assim o código já escrito para os cliques de botão.
        *           1de2 - Penso que seja possível criar um event handler genérico, que simplesmente aceite qualquer tecla do computador.
        *           2de2 - Entretanto, uma vantagem desse método é que qualquer tecla não presente não afeta o programa porque ela não desencadeia nenhuma ação        
        */
        private void ex38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r") // se tecla Enter, ativa o botão H
                btnCalcularH.PerformClick();
        }

        private void btnCalcularH_MouseHover(object sender, EventArgs e)
        {
            lblMouseHover.Visible = true;
            lblMouseHover.Text = "Pressione Enter";
        }

        private void btnCalcularH_MouseLeave(object sender, EventArgs e)
        {
            lblMouseHover.Visible = false;
        }
    }
}
