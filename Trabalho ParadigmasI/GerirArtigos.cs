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
    public partial class GerirArtigos : Form
    {
        public GerirArtigos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarArtigo AA = new AdicionarArtigo();
            AA.ShowDialog();
        }

        private void ButtonAtualizarStock_Click(object sender, EventArgs e)
        {
            AtualizarStock AS = new AtualizarStock();
            AS.ShowDialog();
        }

        private void ButtonEliminarArtigo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
