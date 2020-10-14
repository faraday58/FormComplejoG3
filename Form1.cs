using System;
using System.Windows.Forms;

namespace FormComplejos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (rdbSuma.Checked)
            {
                float real = float.Parse(txtbComReal1.Text);
                float imag = float.Parse(txtbComImag1.Text);
                Complejo c1 = new Complejo(real, imag);
                real = float.Parse(txtbComReal2.Text);
                imag = float.Parse(txtbComImag2.Text);
                Complejo c2 = new Complejo(real, imag);
                Complejo c3 = c1 + c2;
                lbResultadoSuma.Text = c3.ToString();
            }
        }



        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugar.Visible = false;
            lbOperador.Text = "+";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugar.Visible = false;
            lbOperador.Text = "-";
        }

        private void rdbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugar.Visible = false;
            lbOperador.Text = "x";
        }

        private void rdbConjugar_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugar.Visible = true;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (rdbResta.Checked)
            {
                float real = float.Parse(txtbComReal1.Text);
                float imag = float.Parse(txtbComImag1.Text);
                Complejo c1 = new Complejo(real, imag);
                real = float.Parse(txtbComReal2.Text);
                imag = float.Parse(txtbComImag2.Text);
                Complejo c2 = new Complejo(real, imag);
                Complejo c3 = c1 - c2;
                lbResultadoSuma.Text = c3.ToString();
            }
        }
    }
}
