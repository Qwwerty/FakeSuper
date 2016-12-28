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
    public partial class GerirPontosDosClientes : Form
    {
        public GerirPontosDosClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtribuirCartao AC = new AtribuirCartao();
            AC.ShowDialog();
        }

        private void ButtonRegistarCompras_Click(object sender, EventArgs e)
        {
            RegistarCompras RC = new RegistarCompras();
            RC.ShowDialog();
        }

        private void ButtonConsultarCompras_Click(object sender, EventArgs e)
        {
            ConsultarCompras CC = new ConsultarCompras();
            CC.ShowDialog();
        }

        private void ButtonConsultarSaldo_Click(object sender, EventArgs e)
        {
            ConsultarSaldo CS = new ConsultarSaldo();
            CS.ShowDialog();
        }

        private void ButtonGerirPontosVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
