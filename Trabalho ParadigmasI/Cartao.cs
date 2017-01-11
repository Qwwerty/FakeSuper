using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    //Get e Seters
    class Cartao
    {
        private Cliente dono_cartao;
        private List<float> movimentos;
        private float saldo;
        private List<Artigo> lista_compras;
        private int pontos;

        public Cliente DonoCartao
        {
            get { return dono_cartao; }
            set { dono_cartao = value; }
        }

        public List<float> Movimentos
        {
            get { return movimentos; }
            set { movimentos = value; }
        }

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public List<Artigo> Lista_Compras
        {
            get { return lista_compras; }
            set { lista_compras = value; }
        }

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }
        //Constructor
        public Cartao(Cliente NovoCliente)
        {
            this.dono_cartao = NovoCliente;
            this.movimentos = new List<float>(); //como exigido na ficha
            this.saldo = 0;
            this.pontos = 0;
        }

    }
}
