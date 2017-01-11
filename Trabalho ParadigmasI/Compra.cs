using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    class Compra
    {
        private Cliente cliente_que_comprou;
        private List<Artigo> artigos_da_compra;
        private int quantidade_de_artigos;
        private float total_compra;

        public Cliente Cliente_Que_Comprou
        {
            get { return cliente_que_comprou; }
            set { cliente_que_comprou = value; }
        }

        public List<Artigo> Artigos_Da_Compra
        {
            get { return artigos_da_compra; }
            set { artigos_da_compra = value; }
        }

        public int Quantidade_De_Artigos
        {
            get { return quantidade_de_artigos; }
            set { quantidade_de_artigos = value; }
        }

        public float Total_Compra
        {
            get { return total_compra; }
            set { total_compra = value; }
        }
        public Compra(Cliente Cliente)
        {
            this.cliente_que_comprou = Cliente;
            this.artigos_da_compra =new List<Artigo>();
            this.total_compra = 0; //Depois vamos fazer um ciclo for correr a lista e artigo.preco=artigo.preco+artigo.preco
            this.quantidade_de_artigos = 0; //Depois vamos fazer um ciclo for ate ao fim da lista e em casa volta encrementar artigos.
        }
    }
}
