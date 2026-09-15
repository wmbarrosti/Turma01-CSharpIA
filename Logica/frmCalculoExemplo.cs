using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class frmCalculoExemplo : Form
    {
        public frmCalculoExemplo()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo N1");
                txtN1.Focus();
                txtN1.Clear();
            }

            else if (txtN2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo N2");
                txtN2.Focus();
                txtN2.Clear();

            }
            else
            {

                double n1, n2, resultado;

                try
                {
                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);

                    resultado = n1 + n2;

                    lblResultado.Text = Convert.ToString(resultado);

                }
                catch
                {
                    MessageBox.Show("Digite somente número");
                }
              
                
            }

        }
    }
}
