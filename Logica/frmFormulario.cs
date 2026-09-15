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
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo");
            }
            else
            {
                MessageBox.Show("Boa noite " + txtNome.Text);
            }


        }
    }

}
