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
    public partial class ex41 : Form
    {
        public ex41()
        {
            InitializeComponent();
            radioButton1.Checked = true; // deixa selecionado na opção Solteiro só quando inicia
        }

        private void chkBoxFem_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkBoxFem.Checked == true) && (chkBoxMasc.Checked = true))
            {
                chkBoxMasc.Checked = false;
            }
            if ((chkBoxMasc.Checked == false) && (chkBoxFem.Checked == false))
                chkBoxFem.Checked = true;
                //MessageBox.Show("oi");
            
        }

        private void chkBoxMasc_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkBoxMasc.Checked == true) && (chkBoxFem.Checked == true))
            {
                chkBoxFem.Checked = false;
            }
            if ((chkBoxMasc.Checked == false) && (chkBoxFem.Checked == false))
                chkBoxMasc.Checked = true;
        }

        // verificando se todos os campos estão preenchidos (INCOMPLETO)
        public bool camposEmBranco()
        {
            if (txtBoxNome.Text != "")
            {
                if (txtBoxTel.Text != "")
                {
                    if (mskdTxtBoxSalarioPret.Text != "")
                    {
                        if (cmbBoxIdade.Text != "")
                        {
                            if (listBoxDistancia.Text != "")
                            {
                                if (listBoxTempoDeExp.Text != "")
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        int i = 0;
        // botão Candidatar-se
        private void btnCandidatar_Click(object sender, EventArgs e)
        {
            bool paraTest = false; // deixar em true para teste, false para entregar
            if (paraTest && i == 0)
            {
                txtBoxNome.Text = "Johnny";
                txtBoxTel.Text = "911";
                mskdTxtBoxSalarioPret.Text = "999";
                cmbBoxIdade.SelectedIndex = 3;
                listBoxDistancia.SelectedIndex = 2;
                listBoxTempoDeExp.SelectedIndex = 2;
                i++;
            }


            bool cadastroValido = camposEmBranco();
            if (!cadastroValido)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                /*
                 *   Se o candidato tem até um ano de experiência, agradecer a participação, dizer que não contém requisitos necessários para preencher a vaga. 
                 *   Se  o  candidato  tem  entre  um  e  dois  anos  de  experiência,  diga  para  aguardar,  que  será chamado para um teste. 
                 *   Se  morar  a  mais  que  100KM  da  empresa  (MESMO  QUE  PREENCHA  OS  REQUISITOS ACIMA), 
                 * informar que não preenche os requisitos pois a empresa que a empresa não fornece transporte. 
                 *  SE  PREENCHER  OS  REQUISITOS  ACIMA  a  faixa  salarial  deve  ser  de  R$  1.000,00  a  R$ 2.500,00. 
                 * Valor diferente, não deve estar sendo contratado.  Observe que este item anula os demais.
                 */

                double.TryParse(mskdTxtBoxSalarioPret.Text, out double sal); // substring?

                if (listBoxTempoDeExp.SelectedIndex == 0)
                    MessageBox.Show("Você não preenche os requisitos necessários para a vaga.");
                else if (listBoxDistancia.SelectedIndex == 3)
                    MessageBox.Show("A empresa não oferece transporte. Você mora muito longe. ):");
                else if (sal < 1000 || sal > 2500)
                    MessageBox.Show("Pretensão salarial: " + sal.ToString("N2") + "\nSua pretensão salarial está inadequada.");
                else if (listBoxTempoDeExp.SelectedIndex == 1)
                    MessageBox.Show("Você será chamado para uma entrevista.");
                else
                    MessageBox.Show("A vaga é sua!");
            }
        }

        private void chkBoxAutoComplete_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxAutoComplete.Enabled = false;
            chkBoxAutoComplete.Visible = false;

            txtBoxNome.Text = "Anthony Hawk";
            txtBoxTel.Text = "+5501997007333";
            cmbBoxIdade.SelectedItem = "51";
            chkBoxMasc.Checked = true;
            radioButton2.Checked = true;
            listBoxDistancia.SelectedIndex = 2;
            listBoxTempoDeExp.SelectedIndex = 4;
            mskdTxtBoxSalarioPret.Text = "2499,99";

            btnCandidatar.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Text = "";
            txtBoxTel.Text = "";
            cmbBoxIdade.SelectedItem = null;
            chkBoxMasc.Checked = true; chkBoxFem.Checked = false;
            radioButton1.Checked = true;
            listBoxDistancia.SelectedValue = null;
            listBoxTempoDeExp.SelectedValue = null;
            mskdTxtBoxSalarioPret.Text = "";

            txtBoxNome.Focus();
        }
    }
}
