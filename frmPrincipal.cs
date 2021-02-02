using System;
using System.Windows.Forms;

namespace InterfaceCurriculo
{
    public partial class frmGerador : Form
    {
        public frmGerador()
        {
            InitializeComponent();
        }

        private void chbCursos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCursos.Checked == true)
            {
                painelCursos.Visible = true;
            }
            else
            {
                painelCursos.Visible = false;
            }
        }

        private void chbEnsinoSuperior_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEnsinoSuperior.Checked == true)
            {
                painelEnsinoSuperior.Visible = true;
            }
            else
            {
                painelEnsinoSuperior.Visible = false;
            }
        }

        private void chbEmprego1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmprego1.Checked == true)
            {
                painelEmpresa1.Visible = true;
                chbEmprego2.Enabled = false;
                chbEmprego3.Enabled = false;
                chbEmprego4.Enabled = false;
                chbPrimeiroEmprego.Enabled = false;
            }
            else
            {
                painelEmpresa1.Visible = false;
                chbEmprego2.Enabled = true;
                chbEmprego3.Enabled = true;
                chbEmprego4.Enabled = true;
                chbPrimeiroEmprego.Enabled = true;
            }
        }

        private void chbEmprego2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmprego2.Checked == true)
            {
                painelEmpresa1.Visible = true;
                painelEmpresa2.Visible = true;
                chbEmprego1.Enabled = false;
                chbEmprego3.Enabled = false;
                chbEmprego4.Enabled = false;
                chbPrimeiroEmprego.Enabled = false;

            }
            else
            {
                painelEmpresa1.Visible = false;
                painelEmpresa2.Visible = false;
                chbEmprego1.Enabled = true;
                chbEmprego3.Enabled = true;
                chbEmprego4.Enabled = true;
                chbPrimeiroEmprego.Enabled = true;

            }
        }

        private void chbEmprego3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmprego3.Checked == true)
            {
                painelEmpresa1.Visible = true;
                painelEmpresa2.Visible = true;
                painelEmpresa3.Visible = true;
                chbEmprego1.Enabled = false;
                chbEmprego2.Enabled = false;
                chbEmprego4.Enabled = false;
                chbPrimeiroEmprego.Enabled = false;

            }
            else
            {
                painelEmpresa1.Visible = false;
                painelEmpresa2.Visible = false;
                painelEmpresa3.Visible = false;
                chbEmprego1.Enabled = true;
                chbEmprego2.Enabled = true;
                chbEmprego4.Enabled = true;
                chbPrimeiroEmprego.Enabled = true;
            }
        }

        private void chbEmprego4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmprego4.Checked == true)
            {
                painelEmpresa1.Visible = true;
                painelEmpresa2.Visible = true;
                painelEmpresa3.Visible = true;
                painelEmpresa4.Visible = true;
                chbEmprego1.Enabled = false;
                chbEmprego2.Enabled = false;
                chbEmprego3.Enabled = false;
                chbPrimeiroEmprego.Enabled = false;
            }
            else
            {
                painelEmpresa1.Visible = false;
                painelEmpresa2.Visible = false;
                painelEmpresa3.Visible = false;
                painelEmpresa4.Visible = false;
                chbEmprego1.Enabled = true;
                chbEmprego2.Enabled = true;
                chbEmprego3.Enabled = true;
                chbPrimeiroEmprego.Enabled = true;
            }
        }

        private void chbPrimeiroEmprego_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrimeiroEmprego.Checked == true)
            {
                chbEmprego1.Enabled = false;
                chbEmprego2.Enabled = false;
                chbEmprego3.Enabled = false;
                chbEmprego4.Enabled = false;
                lblShowPrimeiro.Visible = true;
            }
            else
            {
                chbEmprego1.Enabled = true;
                chbEmprego2.Enabled = true;
                chbEmprego3.Enabled = true;
                chbEmprego4.Enabled = true;
                lblShowPrimeiro.Visible = false;
            }
        }

    }
}
