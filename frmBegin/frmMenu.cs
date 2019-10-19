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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmbBoxMenu.Focus();
        }

        // Exercício 38
        private void ex38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   // se um form já estiver aberto, ele não abre duas vezes
                if (Application.OpenForms["ex38"] == null)
                {
                    ex38 ob38 = new ex38(); // criar um novo objeto do form (que é uma classe?)
                    ob38.MdiParent = this; // definir o pai como this (this = frmMenu)
                    ob38.Show(); // mostrar o objeto/form instanciado
                }
            }
            catch { } // não deve ser Boas Práticas™️ fazer um catch vazio mas é o que tem pra janta
        }

        // Exercício 39
        private void ex39ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["ex39"] == null)
                {
                    ex39 ob39 = new ex39();
                    ob39.MdiParent = this;
                    ob39.Show();
                }
            }
            catch { }
        }

        private void ex40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["ex40"] == null)
                {
                    ex40 ob40 = new ex40();
                    ob40.MdiParent = this;
                    ob40.Show();
                }
            }
            catch { }
        }

        private void ex41ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["ex41"] == null)
                {
                    ex41 ob41 = new ex41();
                    ob41.MdiParent = this;
                    ob41.Show();
                }
            }
            catch { }
        }

        private void ex42ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["ex42"] == null)
                {
                    ex42 ob42 = new ex42();
                    ob42.MdiParent = this;
                    ob42.Show();
                }
            }
            catch { }
        }

        private void frmMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r": btnGo.PerformClick(); break;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (cmbBoxMenu.Text)
            {
                case "38": ex38ToolStripMenuItem.PerformClick(); break;
                case "39": ex39ToolStripMenuItem.PerformClick(); break;
                case "40": ex40ToolStripMenuItem.PerformClick(); break;
                case "41": ex41ToolStripMenuItem.PerformClick(); break;
                case "42": ex42ToolStripMenuItem.PerformClick(); break;
                default: break;
            }
        }
    }
}
