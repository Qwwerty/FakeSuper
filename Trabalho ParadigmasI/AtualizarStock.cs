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
    public partial class AtualizarStock : Form
    {
        public AtualizarStock()
        {
            InitializeComponent();
        }

        private void ButtonAtualizarStockCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende cancelar?", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void ButtonAtualizarStockConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
