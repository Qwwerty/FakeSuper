using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    class Compra
    {
        private Cliente clienteQueComprou;
        public Cliente ClienteQueComprou
        {
            get { return clienteQueComprou; }
            set { clienteQueComprou = value; }
        }

        private List<Artigo> artigosDaCompra;
        public List<Artigo> ArtigosDaCompra
        {
            get { return artigosDaCompra; }
            set { artigosDaCompra = value; }
        }

        private int quantidadeDeArtigos;
        public int QuantidadeDeArtigos
        {
            get { return quantidadeDeArtigos; }
            set { quantidadeDeArtigos = value; }
        }

        private float totalCompra;
        public float TotalCompra
        {
            get { return totalCompra; }
            set { totalCompra = value; }
        }
        public Compra(Cliente Cliente)
        {
            clienteQueComprou = Cliente;
            artigosDaCompra =new List<Artigo>();
            totalCompra = 0; //Depois vamos fazer um ciclo for correr a lista e artigo.preco=artigo.preco+artigo.preco
            quantidadeDeArtigos = 0; //Depois vamos fazer um ciclo for at6e ao fim da lista e em casa volta encrementar artigos.
        }
    }
}
