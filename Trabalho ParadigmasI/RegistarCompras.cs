using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_ParadigmasI
{
    public partial class RegistarCompras : Form
    {
        public RegistarCompras()
        {
            InitializeComponent();
        }

        private void ButtonCancelarRegistarCompras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende cancelar?", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
