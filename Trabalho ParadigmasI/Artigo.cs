using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ParadigmasI
{
    class Artigo
    {
        private string nome_artigo;
        private string codigo_artigo;
        private string descricao;
        private float preco;
        private int stock;

        public string Nome_Artigo
        {
            get { return nome_artigo; }
            set { nome_artigo = value; }
        }

        public string Codigo_Artigo
        {
            get { return codigo_artigo; }
            set { codigo_artigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Artigo(string nome_artigo,string codigo_artigo,string descricao,float preco,int stock)
        {
            this.nome_artigo = nome_artigo.ToLower();
            this.codigo_artigo = codigo_artigo;
            this.descricao = descricao;
            this.preco = preco;
            this.stock = stock;
        }
    }
}
